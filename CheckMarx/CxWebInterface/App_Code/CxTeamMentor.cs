using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
///     Summary description for CxTeamMentor
/// </summary>
public class CxTeamMentor


{
    public void TMFilterFor_CxQueryCollectionResponse(CxQueryCollectionResponse cxQueryCollectionResponse)
    {
        IEnumerable<CxWSQuery> queries = from queryGroup in cxQueryCollectionResponse.QueryGroups
                                         from query in queryGroup.Queries
                                         select query;


        foreach (CxWSQuery query in queries)
        {
            query.Cwe = -query.QueryId; // set the Cwe value to the negative of the QueryId
            query.Name += "_TM"; // Temp query name minor change
        }
    }


    public void TMFilterFor_CxWSResponseResultCollection(CxWSResponseResultCollection cxWsResponseResultCollection)

    {
        AuditScanResult[] results = cxWsResponseResultCollection.ResultCollection.Results;

        foreach (AuditScanResult result in results)
        {
            result.CWE = -result.QueryId; // set the Cwe value to the negative of the QueryId
            result.QueryName += "_TM"; // Temp query name minor change
        }
    }


    public void TMFilterFor_CxWSResponseQueryDescription(int cweId,
                                                         CxWSResponseQueryDescription cxWsResponseQueryDescription)
    {
        if (cxWsResponseQueryDescription.IsSuccesfull)
        {
            if (cweId < 0)
            {
                if (CxTeamMentor_Mappings.Tm_QueryId_Mappings.ContainsKey(cweId))

                {
                    cxWsResponseQueryDescription.QueryDescription =String.Format(CxTeamMentor_Mappings.HtmlRedirectTemplate,CxTeamMentor_Mappings.Tm_QueryId_Mappings[cweId]);
                }

                else
                    cxWsResponseQueryDescription.QueryDescription =
                        String.Format("The TeamMentor article with Id {0} could not be found", cweId);
            }
        }
    }
}