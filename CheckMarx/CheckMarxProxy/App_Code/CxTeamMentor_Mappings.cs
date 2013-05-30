using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Hosting;
using System.Xml.Serialization;

/// <summary>
/// Summary description for CxTeamMentor_Mappings
/// </summary>
public class CxTeamMentor_Mappings
{
    public static Dictionary<int, string> Tm_QueryId_Mappings { get; set; }
    public static string HtmlRedirectTemplate { get; set; }
    private static readonly string TeamMentor_Target_Server = @"";

    static CxTeamMentor_Mappings()
    {
        LoadData();
    }


    public static void LoadData()
    {
        HtmlRedirectTemplate = "<html><head><meta http-equiv=\"refresh\" content=\"0;" +
                               " url=https://vulnerabilities.teammentor.net/article/{0} \"></head></html>";

        var file = HostingEnvironment.MapPath(@"/App_Code/CheckMarxMapping.xml");

        string xmlResult;
        xmlResult = string.Empty;
        using (var fs = new FileStream(file, FileMode.Open))
        {
            var sw = new StreamReader(fs);
            xmlResult = sw.ReadLine();
        }
        var checkMarxDataMapping = new CheckMarxDataMapping();
        var serializer = new XmlSerializer(typeof(CheckMarxDataMapping));
        if (xmlResult != null)
        {
            using (var reader = new StringReader(xmlResult))
                checkMarxDataMapping = (CheckMarxDataMapping) serializer.Deserialize(reader);
        }
        //Loading a Dictionary
        if (checkMarxDataMapping != null)
            checkMarxDataMapping.Mapping.ForEach(x => Tm_QueryId_Mappings.Add(x.QueryId, x.Guid));

    }
    
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

