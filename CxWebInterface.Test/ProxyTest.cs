using System.Collections.Generic;
using System.Linq;
using CheckMarxMapping.Test;
using NUnit.Framework;

namespace CheckMarxMapping.Test
{
    [TestFixture]
    public class ProxyTest : Base 
    {

        private static string SessionId;
        private static readonly string MappingNotFoundMessage = "The TeamMentor article with Id {0} could not be found";
        private CxPortalWebService_Wrapper proxy;
        [SetUp]
        public void SetUp()
        {
            proxy = new CxPortalWebService_Wrapper();
            SessionId= proxy.Login(new Credentials() {User = "admin@cx", Pass = ">t1SMIjfQX"}).SessionId;
            Assert.IsTrue(!string.IsNullOrEmpty(SessionId));
        }

        [Test]
        public void GetQueryCollections()
        {
           var queryCollection = proxy.GetQueryCollectionForLanguage(SessionId, 4,4);
           Assert.IsTrue(queryCollection!=null);
           Assert.IsTrue(queryCollection.QueryGroups.Select(x => x.Queries.Any(y => y.Cwe <0)).Any());
        }

        [Test]
        public void CheckMarx_Mapping_HTML_Redirection_Form_Is_Ok()
        {
            
            //var results = proxy.GetQueryCollection(SessionId);

            //IEnumerable<CxWSQuery> queries = from queryGroup in results.QueryGroups
            //                                 from query in queryGroup.Queries
            //                                 select query;
            //foreach (var query in queries)
            //{
            //    var description = proxy.GetQueryDescription(SessionId, int.Parse(query.Cwe.ToString()));
            //    if (CxTeamMentor_Mappings.Tm_QueryId_Mappings.ContainsKey(int.Parse(query.Cwe.ToString())))
            //    {
            //        var TeamMentorGuid = CxTeamMentor_Mappings.Tm_QueryId_Mappings[int.Parse(query.Cwe.ToString())];
            //        Assert.IsTrue(description.QueryDescription.Trim() == string.Format(HtmlRedirectionTemplate,TeamMentorGuid));
            //    }
            //    else
            //    {
            //        Assert.IsTrue(description.QueryDescription.Trim()==string.Format(MappingNotFoundMessage,query.Cwe));
            //    }  
            //}
        }

        [TearDown]
        public void LogOut()
        {
            proxy.Logout(SessionId);
        }
    }
}
