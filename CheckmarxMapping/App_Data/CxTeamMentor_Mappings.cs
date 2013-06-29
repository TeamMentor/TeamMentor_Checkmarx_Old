using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

/// <summary>
/// Summary description for CxTeamMentor_Mappings
/// </summary>
public class CxTeamMentor_Mappings
{
    #region static variables 
    public static Dictionary<int, string> Tm_QueryId_Mappings { get; set; }
    public static string HtmlRedirectTemplate { get; set; }

    #endregion

    #region class contructor
    static CxTeamMentor_Mappings()
    {
        Tm_QueryId_Mappings = new Dictionary<int, string>();
        LoadData();
    }

    #endregion    

    #region Methods
    public static void LoadData()
    {
        HtmlRedirectTemplate = "<html><head><meta http-equiv=\"refresh\" content=\"0;" +
                               "url=http://checkmarx.teammentor.net/article/{0}\"></head></html>";

        //var file = HostingEnvironment.MapPath(@"/App_Code/CheckMarxMapping.xml");
        var file = AppDomain.CurrentDomain.BaseDirectory + @"App_Data\CheckMarxMapping.xml";

        string xmlResult;
        
        using (var fs = new FileStream(file, FileMode.Open))
        {
            var sw = new StreamReader(fs);
            xmlResult = sw.ReadToEnd();
        }
        CheckMarxDataMapping checkMarxDataMapping;

        var serializer = new XmlSerializer(typeof(CheckMarxDataMapping));
        using (var reader = new StringReader(xmlResult))
            checkMarxDataMapping = (CheckMarxDataMapping) serializer.Deserialize(reader);
        //Loading a Dictionary
        if (checkMarxDataMapping != null)
            checkMarxDataMapping.Mapping
                                 .ForEach(x => Tm_QueryId_Mappings.Add(x.QueryId, x.Guid));

    }

    #endregion

}

[Serializable]
public class DataItem
{
    [XmlAttribute]
    public int QueryId { get; set; }

    [XmlAttribute]
    public String Guid { get; set; }
}

[Serializable]
public class CheckMarxDataMapping
{
    [XmlArray]
    public List<DataItem> Mapping;

    public CheckMarxDataMapping()
    {
        Mapping = new List<DataItem>();
    }
}

