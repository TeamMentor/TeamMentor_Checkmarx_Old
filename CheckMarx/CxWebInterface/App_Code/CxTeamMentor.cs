using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
///     Summary description for CxTeamMentor
/// </summary>
public class CxTeamMentor


{
    private static readonly long TeamMentorIdentifier = 1000000;

    public void TMFilterFor_CxQueryCollectionResponse(CxQueryCollectionResponse cxQueryCollectionResponse)
    {
        IEnumerable<CxWSQuery> queries = from queryGroup in cxQueryCollectionResponse.QueryGroups
                                         from query in queryGroup.Queries
                                         select query;


        foreach (var query in queries)
        {
            query.Cwe = TeamMentorIdentifier + query.QueryId; // set the Cwe value to the negative of the QueryId
            query.Name += "_TM"; // Temp query name minor change
        }
    }


    public void TMFilterFor_CxWSResponseResultCollection(CxWSResponseResultCollection cxWsResponseResultCollection)

    {
        AuditScanResult[] results = cxWsResponseResultCollection.ResultCollection.Results;

        foreach (AuditScanResult result in results)
        {
            result.CWE = TeamMentorIdentifier+ result.QueryId; // set the Cwe value to the negative of the QueryId
            result.QueryName += "_TM"; // Temp query name minor change
        }
    }


    public void TMFilterFor_CxWSResponseQueryDescription(int cweId,CxWSResponseQueryDescription cxWsResponseQueryDescription)
    {
        if (cxWsResponseQueryDescription.IsSuccesfull && cweId > TeamMentorIdentifier)
        {
            cxWsResponseQueryDescription.QueryDescription =
                !CxTeamMentor_Mappings.Tm_QueryId_Mappings.ContainsKey(cweId)
                    ? String.Format("The TeamMentor article with Id {0} could not be found",cweId)
                    : String.Format(CxTeamMentor_Mappings.HtmlRedirectTemplate, CxTeamMentor_Mappings.Tm_QueryId_Mappings[cweId]);
        }
    }
}