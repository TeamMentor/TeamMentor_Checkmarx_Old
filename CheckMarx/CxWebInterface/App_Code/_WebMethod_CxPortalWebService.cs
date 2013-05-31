//O2File:CxPortalWebService.cs
using System.Web.Services;
using System;
[WebService(Namespace = "http://Checkmarx.com/")]
public class CxPortalWebService_Wrapper
{
	public CxPortalWebService _web_Service { get; set; }
	public CxPortalWebService_Wrapper()
	{
		_web_Service = new CxPortalWebService();
	}
	[WebMethod()]
	public CxQueryCollectionResponse GetQueryCollection(string sessionId)
	{
		CxQueryCollectionResponse result = _web_Service.GetQueryCollection(sessionId);
		return result;
	}
	[WebMethod()]
	public CxWSResponsePresetDetails GetPresetDetails(string sessionId, long id)
	{
		CxWSResponsePresetDetails result = _web_Service.GetPresetDetails(sessionId, id);
		return result;
	}
	[WebMethod()]
	public CxWSResponsePresetDetails CreateNewPreset(string sessionId, CxPresetDetails presrt)
	{
		CxWSResponsePresetDetails result = _web_Service.CreateNewPreset(sessionId, presrt);
		return result;
	}
	[WebMethod()]
	public CxWSResponsePresetDetails UpdatePreset(string sessionId, CxPresetDetails presrt)
	{
		CxWSResponsePresetDetails result = _web_Service.UpdatePreset(sessionId, presrt);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse DeletePreset(string sessionId, long id)
	{
		CxWSBasicRepsonse result = _web_Service.DeletePreset(sessionId, id);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse IsValidPresetName(string sessionID, string presetName)
	{
		CxWSBasicRepsonse result = _web_Service.IsValidPresetName(sessionID, presetName);
		return result;
	}
	[WebMethod()]
	public CxWSResponceQuerisForScan GetQueriesForScan(string sessionID, long scanId)
	{
		CxWSResponceQuerisForScan result = _web_Service.GetQueriesForScan(sessionID, scanId);
		return result;
	}
	[WebMethod()]
	public CxWSResponceQuerisForScanAndId GetQueriesForScanByRunId(string sessionID, string runId)
	{
		CxWSResponceQuerisForScanAndId result = _web_Service.GetQueriesForScanByRunId(sessionID, runId);
		return result;
	}
	[WebMethod()]
	public CxWSResponceScanResults GetResultsForQuery(string sessionID, long scanId, long queryId)
	{
		CxWSResponceScanResults result = _web_Service.GetResultsForQuery(sessionID, scanId, queryId);
		return result;
	}
	[WebMethod()]
	public CxWSResponceScanResults GetResultsForQueryQroup(string sessionID, long scanId, long queryGroupId)
	{
		CxWSResponceScanResults result = _web_Service.GetResultsForQueryQroup(sessionID, scanId, queryGroupId);
		return result;
	}
	[WebMethod()]
	public CxWSResponceScanResults GetResultsForScan(string sessionID, long scanId)
	{
		CxWSResponceScanResults result = _web_Service.GetResultsForScan(sessionID, scanId);
		return result;
	}
	[WebMethod()]
	public CxWSResponceResultPath GetResultPath(string sessionId, long scanId, long pathId)
	{
		CxWSResponceResultPath result = _web_Service.GetResultPath(sessionId, scanId, pathId);
		return result;
	}
	[WebMethod()]
	public CxWSResponceFileNames GetFileNamesForPath(string sessionId, long scanId, long pathId)
	{
		CxWSResponceFileNames result = _web_Service.GetFileNamesForPath(sessionId, scanId, pathId);
		return result;
	}
	[WebMethod()]
	public CxWSResponseResultPaths GetResultPathsForQuery(string sessionId, long scanId, long queryId)
	{
		CxWSResponseResultPaths result = _web_Service.GetResultPathsForQuery(sessionId, scanId, queryId);
		return result;
	}
	[WebMethod()]
	public CxWSResponceScanResults GetResultsBySeverity(string sessionId, long scanId, int Severity)
	{
		CxWSResponceScanResults result = _web_Service.GetResultsBySeverity(sessionId, scanId, Severity);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse SavePredefinedCommands(string sessionID, CxPredefinedCommand[] predefinedCommands)
	{
		CxWSBasicRepsonse result = _web_Service.SavePredefinedCommands(sessionID, predefinedCommands);
		return result;
	}
	[WebMethod()]
	public CxWSResponsePredefinedCommands GetPredefinedCommands(string sessionId)
	{
		CxWSResponsePredefinedCommands result = _web_Service.GetPredefinedCommands(sessionId);
		return result;
	}
	[WebMethod()]
	public CxWSResponseNameList GetExecutableList(string sessionId)
	{
		CxWSResponseNameList result = _web_Service.GetExecutableList(sessionId);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse UpdatePermission(string sessionID, CxPermission permission, string teamId)
	{
		CxWSBasicRepsonse result = _web_Service.UpdatePermission(sessionID, permission, teamId);
		return result;
	}
	[WebMethod()]
	public CxWSResponseUserData GetProjectAssignUsers(string sessionID, long projectId)
	{
		CxWSResponseUserData result = _web_Service.GetProjectAssignUsers(sessionID, projectId);
		return result;
	}
	[WebMethod()]
	public CxWSResponseBool IsAllowAutoSignIn()
	{
		CxWSResponseBool result = _web_Service.IsAllowAutoSignIn();
		return result;
	}
	[WebMethod()]
	public CxWSResponsePivotTable GetPivotData(string SessionID, PivotViewClientType viewType)
	{
		CxWSResponsePivotTable result = _web_Service.GetPivotData(SessionID, viewType);
		return result;
	}
	[WebMethod()]
	public CxWSResponsePivotLayouts GetPivotLayouts(string SessionID)
	{
		CxWSResponsePivotLayouts result = _web_Service.GetPivotLayouts(SessionID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse SavePivotLayout(string SessionID, CxPivotLayout layout)
	{
		CxWSBasicRepsonse result = _web_Service.SavePivotLayout(SessionID, layout);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse DeletePivotLayout(string SessionID, long LayoutID)
	{
		CxWSBasicRepsonse result = _web_Service.DeletePivotLayout(SessionID, LayoutID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse RegisterSaasPendingUser(SaasPendingUser pendingUser, string activationPageUrl)
	{
		CxWSBasicRepsonse result = _web_Service.RegisterSaasPendingUser(pendingUser, activationPageUrl);
		return result;
	}
	[WebMethod()]
	public CxWSResponseSaasLoginData ActivateSaasUser(string userToken)
	{
		CxWSResponseSaasLoginData result = _web_Service.ActivateSaasUser(userToken);
		return result;
	}
	[WebMethod()]
	public CxWSResponseSaasPackage GetSaasPackages()
	{
		CxWSResponseSaasPackage result = _web_Service.GetSaasPackages();
		return result;
	}
	[WebMethod()]
	public CxWSResponseSaasLoginData SaasLogin(Credentials applicationCredentials)
	{
		CxWSResponseSaasLoginData result = _web_Service.SaasLogin(applicationCredentials);
		return result;
	}
	[WebMethod()]
	public CxWSResponseEngineServers GetEngineServers(string sessionID)
	{
		CxWSResponseEngineServers result = _web_Service.GetEngineServers(sessionID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse UpdateEngineServer(string sessionID, CxEngineServer engine)
	{
		CxWSBasicRepsonse result = _web_Service.UpdateEngineServer(sessionID, engine);
		return result;
	}
	[WebMethod()]
	public CxWSResponseEngineServerId CreateEngineServer(string sessionID, CxEngineServer engine)
	{
		CxWSResponseEngineServerId result = _web_Service.CreateEngineServer(sessionID, engine);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse DeleteEngineServer(string sessionID, long id)
	{
		CxWSBasicRepsonse result = _web_Service.DeleteEngineServer(sessionID, id);
		return result;
	}
	[WebMethod()]
	public CxWSResponseRunID Scan(string sessionId, CliScanArgs args)
	{
		CxWSResponseRunID result = _web_Service.Scan(sessionId, args);
		return result;
	}
	[WebMethod()]
	public CxWSResponseProjectsScansList GetProjectsWithScans(string sessionId)
	{
		CxWSResponseProjectsScansList result = _web_Service.GetProjectsWithScans(sessionId);
		return result;
	}
	[WebMethod()]
	public CxWSResponseSourceID UploadProjectWithDefaultSettings(string sessionId, ProjectBasicSettings projectSettings, LocalCodeContainer localCodeContainer)
	{
		CxWSResponseSourceID result = _web_Service.UploadProjectWithDefaultSettings(sessionId, projectSettings, localCodeContainer);
		return result;
	}
	[WebMethod()]
	public CxWSResponseSourceContainer GetSourceCodeForScan(long scanId)
	{
		CxWSResponseSourceContainer result = _web_Service.GetSourceCodeForScan(scanId);
		return result;
	}
	[WebMethod()]
	public CxQueryCollectionResponse GetQueryCollectionForLanguage(string sessionId, int projectType, long projectId)
	{
		CxQueryCollectionResponse result = _web_Service.GetQueryCollectionForLanguage(sessionId, projectType, projectId);
        new CxTeamMentor().TMFilterFor_CxQueryCollectionResponse(result);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse UploadQueries(string sessionId, CxWSQueryGroup[] queries)
	{
		CxWSBasicRepsonse result = _web_Service.UploadQueries(sessionId, queries);
		return result;
	}
	[WebMethod()]
	public CxWSResponseBasicScanData AddScanResultsToProject(string sessionId, long projectId, string sourceId, AuditResultsCollection resultsCollection, string comment)
	{
		CxWSResponseBasicScanData result = _web_Service.AddScanResultsToProject(sessionId, projectId, sourceId, resultsCollection, comment);
		return result;
	}
	[WebMethod()]
	public CxWSResponseResultCollection GetResults(string sessionId, long scanId)
	{
		CxWSResponseResultCollection result = _web_Service.GetResults(sessionId, scanId);
        new CxTeamMentor().TMFilterFor_CxWSResponseResultCollection(result);
		return result;
	}
	[WebMethod()]
	public CXWSResponseResultSummary GetResultSummary(string sessionId, long scanId)
	{
		CXWSResponseResultSummary result = _web_Service.GetResultSummary(sessionId, scanId);
		return result;
	}
	[WebMethod()]
	public CxWSResponseCache GetCache(string sessionId, long scanId)
	{
		CxWSResponseCache result = _web_Service.GetCache(sessionId, scanId);
		return result;
	}
	[WebMethod()]
	public CxWSResponseLoginData Login(Credentials applicationCredentials)
	{
		CxWSResponseLoginData result = _web_Service.Login(applicationCredentials);
		return result;
	}
	[WebMethod()]
	public CxWSResponseLoginData SsoLogin(Credentials encryptedCredentials)
	{
		CxWSResponseLoginData result = _web_Service.SsoLogin(encryptedCredentials);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse Logout(string sessionID)
	{
		CxWSBasicRepsonse result = _web_Service.Logout(sessionID);
		return result;
	}
	[WebMethod()]
	public CxWSResponseGroupList GetAssociatedGroupsList(string SessionID)
	{
		CxWSResponseGroupList result = _web_Service.GetAssociatedGroupsList(SessionID);
		return result;
	}
	[WebMethod()]
	public CxWSResponseConfigSetList GetConfigurationSetList(string SessionID)
	{
		CxWSResponseConfigSetList result = _web_Service.GetConfigurationSetList(SessionID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse IsValidProjectName(string SessionID, string ProjectName, string GroupId)
	{
		CxWSBasicRepsonse result = _web_Service.IsValidProjectName(SessionID, ProjectName, GroupId);
		return result;
	}
	[WebMethod()]
	public CxWSResponseFileSystemLayer GetSharedFileSystemLayer(string SessionID, string Path, Credentials UserCredentials)
	{
		CxWSResponseFileSystemLayer result = _web_Service.GetSharedFileSystemLayer(SessionID, Path, UserCredentials);
		return result;
	}
	[WebMethod()]
	public CxWSResponseFileSystemLayer GetRepositoryFileSystemLayer(string SessionID, string Path, SourceControlSettings SourceControlSettings)
	{
		CxWSResponseFileSystemLayer result = _web_Service.GetRepositoryFileSystemLayer(SessionID, Path, SourceControlSettings);
		return result;
	}
	[WebMethod()]
	public CxWSResponseSourceActionList GetSourceControlActionList(string SessionID, string teamId)
	{
		CxWSResponseSourceActionList result = _web_Service.GetSourceControlActionList(SessionID, teamId);
		return result;
	}
	[WebMethod()]
	public CxWSResponseSourceActionList GetPostScanActionList(string SessionID, string teamId)
	{
		CxWSResponseSourceActionList result = _web_Service.GetPostScanActionList(SessionID, teamId);
		return result;
	}
	[WebMethod()]
	public CxWSResponseProjectID CreateNewProject(string SessionID, ProjectConfiguration Project)
	{
		CxWSResponseProjectID result = _web_Service.CreateNewProject(SessionID, Project);
		return result;
	}
	[WebMethod()]
	public CxWSResponseRunID CreateAndRunProject(string SessionID, ProjectSettings ProjectSettings, LocalCodeContainer LocalCodeContainer, bool visibleToOtherUsers)
	{
		CxWSResponseRunID result = _web_Service.CreateAndRunProject(SessionID, ProjectSettings, LocalCodeContainer, visibleToOtherUsers);
		return result;
	}
	[WebMethod()]
	public CxWSResponseRunID RunScanAndAddToProject(string sessionId, ProjectSettings projectSettings, LocalCodeContainer localCodeContainer, bool visibleToUtherUsers)
	{
		CxWSResponseRunID result = _web_Service.RunScanAndAddToProject(sessionId, projectSettings, localCodeContainer, visibleToUtherUsers);
		return result;
	}
	[WebMethod()]
	public CxWSResponseCountLines CountLines(string sessionId, LocalCodeContainer localCodeContainer)
	{
		CxWSResponseCountLines result = _web_Service.CountLines(sessionId, localCodeContainer);
		return result;
	}
	[WebMethod()]
	public CxWSResponseScanStatusArray GetScansStatuses(string sessionID)
	{
		CxWSResponseScanStatusArray result = _web_Service.GetScansStatuses(sessionID);
		return result;
	}
	[WebMethod()]
	public CxWSResponseScanStatus GetStatusOfSingleScan(string sessionID, string runId)
	{
		CxWSResponseScanStatus result = _web_Service.GetStatusOfSingleScan(sessionID, runId);
		return result;
	}
	[WebMethod()]
	public CxWSResponseQueueRunID PostponeScan(string sessionID, string RunId)
	{
		CxWSResponseQueueRunID result = _web_Service.PostponeScan(sessionID, RunId);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse CancelScan(string sessionID, string RunId)
	{
		CxWSBasicRepsonse result = _web_Service.CancelScan(sessionID, RunId);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse UpdateProjectUserCredentials(string sessionID, long projectID, Credentials credentials)
	{
		CxWSBasicRepsonse result = _web_Service.UpdateProjectUserCredentials(sessionID, projectID, credentials);
		return result;
	}
	[WebMethod()]
	public CxWSResponseProjectsData GetProjectsWithUserCredentials(string sessionID, string username)
	{
		CxWSResponseProjectsData result = _web_Service.GetProjectsWithUserCredentials(sessionID, username);
		return result;
	}
	[WebMethod()]
	public CxWSResponseNameList GetProjectsCredentialUsers(string sessionID)
	{
		CxWSResponseNameList result = _web_Service.GetProjectsCredentialUsers(sessionID);
		return result;
	}
	[WebMethod()]
	public CxWSResponseProjectsDisplayData GetProjectsDisplayData(string sessionID)
	{
		CxWSResponseProjectsDisplayData result = _web_Service.GetProjectsDisplayData(sessionID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse RunProjectImmediately(string sessionID, long projectID)
	{
		CxWSBasicRepsonse result = _web_Service.RunProjectImmediately(sessionID, projectID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse RunProjectIncrementally(string sessionID, long projectID)
	{
		CxWSBasicRepsonse result = _web_Service.RunProjectIncrementally(sessionID, projectID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse DeleteProject(string sessionID, long projectID)
	{
		CxWSBasicRepsonse result = _web_Service.DeleteProject(sessionID, projectID);
		return result;
	}
	[WebMethod()]
	public CxWSResponseProjectConfig GetProjectConfiguration(string sessionID, long projectID)
	{
		CxWSResponseProjectConfig result = _web_Service.GetProjectConfiguration(sessionID, projectID);
		return result;
	}
	[WebMethod()]
	public CxWSResponsProjectProperties GetProjectProperties(string sessionID, long projectID)
	{
		CxWSResponsProjectProperties result = _web_Service.GetProjectProperties(sessionID, projectID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse UpdateProjectConfiguration(string sessionID, long projectID, ProjectConfiguration projectConfiguration)
	{
		CxWSBasicRepsonse result = _web_Service.UpdateProjectConfiguration(sessionID, projectID, projectConfiguration);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse UpdateProjectIncrementalConfiguration(string sessionID, long projectID, ProjectConfiguration projectConfiguration)
	{
		CxWSBasicRepsonse result = _web_Service.UpdateProjectIncrementalConfiguration(sessionID, projectID, projectConfiguration);
		return result;
	}
	[WebMethod()]
	public CxWSResponsProjectChartData GetProjectCharts(string sessionID, long projectID)
	{
		CxWSResponsProjectChartData result = _web_Service.GetProjectCharts(sessionID, projectID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse ResetIgnorePath(string sessionID, long ProjectId)
	{
		CxWSBasicRepsonse result = _web_Service.ResetIgnorePath(sessionID, ProjectId);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse SetFalsePositiveFlag(string sessionID, long ResultId, long PathId, long projectId, bool falsePositiveFlag)
	{
		CxWSBasicRepsonse result = _web_Service.SetFalsePositiveFlag(sessionID, ResultId, PathId, projectId, falsePositiveFlag);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse UpdateResultComment(string sessionID, long ResultId, long PathId, long projectId, string comment)
	{
		CxWSBasicRepsonse result = _web_Service.UpdateResultComment(sessionID, ResultId, PathId, projectId, comment);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse UpdateResultState(string sessionID, long scanId, long PathId, long projectId, string Remarks, int ResultLabelType, string data)
	{
		CxWSBasicRepsonse result = _web_Service.UpdateResultState(sessionID, scanId, PathId, projectId, Remarks, ResultLabelType, data);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse UpdateSetOfResultState(string sessionID, ResultStateData[] resultsStates)
	{
		CxWSBasicRepsonse result = _web_Service.UpdateSetOfResultState(sessionID, resultsStates);
		return result;
	}
	[WebMethod()]
	public CxWSResponseRunID RunScanWithExistingProject(string sessionId, string projectName)
	{
		CxWSResponseRunID result = _web_Service.RunScanWithExistingProject(sessionId, projectName);
		return result;
	}
	[WebMethod()]
	public CxWSResponseScansDisplayData GetScansDisplayData(string sessionID, long projectID)
	{
		CxWSResponseScansDisplayData result = _web_Service.GetScansDisplayData(sessionID, projectID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse DeleteScan(string sessionID, long ScanID)
	{
		CxWSBasicRepsonse result = _web_Service.DeleteScan(sessionID, ScanID);
		return result;
	}
	[WebMethod()]
	public CxWSResponseScanProperties GetScanProperties(string sessionID, long ScanID)
	{
		CxWSResponseScanProperties result = _web_Service.GetScanProperties(sessionID, ScanID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse UpdateScanComment(string sessionID, long ScanID, string Comment)
	{
		CxWSBasicRepsonse result = _web_Service.UpdateScanComment(sessionID, ScanID, Comment);
		return result;
	}
	[WebMethod()]
	public CxWSResponseScansDisplayData GetScansDisplayDataForAllProjects(string sessionID)
	{
		CxWSResponseScansDisplayData result = _web_Service.GetScansDisplayDataForAllProjects(sessionID);
		return result;
	}
	[WebMethod()]
	public CxWSResponseScanSummary GetScanSummary(string i_SessionID, long i_ScanID)
	{
		CxWSResponseScanSummary result = _web_Service.GetScanSummary(i_SessionID, i_ScanID);
		return result;
	}
	[WebMethod()]
	public CxWSResponseScanCompareSummary GetScanCompareSummary(string sessionId, long oldScanId, long newScanId)
	{
		CxWSResponseScanCompareSummary result = _web_Service.GetScanCompareSummary(sessionId, oldScanId, newScanId);
		return result;
	}
	[WebMethod()]
	public CxWSResponseScanCompareReport GetScanCompareReport(string sessionId, long oldScanId, long newScanId)
	{
		CxWSResponseScanCompareReport result = _web_Service.GetScanCompareReport(sessionId, oldScanId, newScanId);
		return result;
	}
	[WebMethod()]
	public CxWSResponceScanCompareResults GetCompareScanResults(string sessionId, long oldScanId, long newScanId)
	{
		CxWSResponceScanCompareResults result = _web_Service.GetCompareScanResults(sessionId, oldScanId, newScanId);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse CreateScanPDFReport(string sessionID, long scanID)
	{
		CxWSBasicRepsonse result = _web_Service.CreateScanPDFReport(sessionID, scanID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse CreateScannedFilesReport(string sessionID, long scanID)
	{
		CxWSBasicRepsonse result = _web_Service.CreateScannedFilesReport(sessionID, scanID);
		return result;
	}
	[WebMethod()]
	public CXWSResponseScanReportStatus GetScanPDFReportStatus(string sessionID, long scanID)
	{
		CXWSResponseScanReportStatus result = _web_Service.GetScanPDFReportStatus(sessionID, scanID);
		return result;
	}
	[WebMethod()]
	public CXWSResponseScanReportStatus GetScannedFilesReportStatus(string sessionID, long scanID)
	{
		CXWSResponseScanReportStatus result = _web_Service.GetScannedFilesReportStatus(sessionID, scanID);
		return result;
	}
	[WebMethod()]
	public CxWSResponseScanResults GetScanPDFReport(string sessionID, long scanID)
	{
		CxWSResponseScanResults result = _web_Service.GetScanPDFReport(sessionID, scanID);
		return result;
	}
	[WebMethod()]
	public CxWSResponseScanResults GetScannedFilesReport(string sessionID, long scanID)
	{
		CxWSResponseScanResults result = _web_Service.GetScannedFilesReport(sessionID, scanID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse CreateScanExcelReport(string sessionID, long scanID)
	{
		CxWSBasicRepsonse result = _web_Service.CreateScanExcelReport(sessionID, scanID);
		return result;
	}
	[WebMethod()]
	public CXWSResponseScanReportStatus GetScanExcelReportStatus(string sessionID, long scanID)
	{
		CXWSResponseScanReportStatus result = _web_Service.GetScanExcelReportStatus(sessionID, scanID);
		return result;
	}
	[WebMethod()]
	public CxWSResponseScanResults GetScanExcelReport(string sessionID, long scanID)
	{
		CxWSResponseScanResults result = _web_Service.GetScanExcelReport(sessionID, scanID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse CreateScanXMLReport(string sessionID, long scanID)
	{
		CxWSBasicRepsonse result = _web_Service.CreateScanXMLReport(sessionID, scanID);
		return result;
	}
	[WebMethod()]
	public CXWSResponseScanReportStatus GetScanXMLReportStatus(string sessionID, long scanID)
	{
		CXWSResponseScanReportStatus result = _web_Service.GetScanXMLReportStatus(sessionID, scanID);
		return result;
	}
	[WebMethod()]
	public CxWSResponseScanResults GetScanXMLReport(string sessionID, long scanID)
	{
		CxWSResponseScanResults result = _web_Service.GetScanXMLReport(sessionID, scanID);
		return result;
	}
	[WebMethod()]
	public CxWSResponseScanResults GetScanXMLReportByRunId(string sessionID, string runId)
	{
		CxWSResponseScanResults result = _web_Service.GetScanXMLReportByRunId(sessionID, runId);
		return result;
	}
	[WebMethod()]
	public CxWSResponseScanResults GetScanPDFReportByRunId(string sessionID, string runId)
	{
		CxWSResponseScanResults result = _web_Service.GetScanPDFReportByRunId(sessionID, runId);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse CreateScanRTFReport(string sessionID, long scanID)
	{
		CxWSBasicRepsonse result = _web_Service.CreateScanRTFReport(sessionID, scanID);
		return result;
	}
	[WebMethod()]
	public CXWSResponseScanReportStatus GetScanRTFReportStatus(string sessionID, long scanID)
	{
		CXWSResponseScanReportStatus result = _web_Service.GetScanRTFReportStatus(sessionID, scanID);
		return result;
	}
	[WebMethod()]
	public CxWSResponseScanResults GetScanRTFReport(string sessionID, long scanID)
	{
		CxWSResponseScanResults result = _web_Service.GetScanRTFReport(sessionID, scanID);
		return result;
	}
	[WebMethod()]
	public CxWSResponseQueryDescription GetQueryDescription(string sessionId, int cweId)
	{
		CxWSResponseQueryDescription result = _web_Service.GetQueryDescription(sessionId, cweId);
	    result.IsSuccesfull = true;
        new CxTeamMentor().TMFilterFor_CxWSResponseQueryDescription(cweId,result);
		return result;
	}
	[WebMethod()]
	public CxWSResponseSourceContent GetSourceByScanID(string sessionID, long scanID, string fileToRetreive)
	{
		CxWSResponseSourceContent result = _web_Service.GetSourceByScanID(sessionID, scanID, fileToRetreive);
		return result;
	}
	[WebMethod()]
	public CxWSResponseResultStateList GetResultStateList(string sessionID)
	{
		CxWSResponseResultStateList result = _web_Service.GetResultStateList(sessionID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse ForgotPassword(string loginUrl, string email)
	{
		CxWSBasicRepsonse result = _web_Service.ForgotPassword(loginUrl, email);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse ResetPasswordByEmail(string passwordChangePageUrl, string email)
	{
		CxWSBasicRepsonse result = _web_Service.ResetPasswordByEmail(passwordChangePageUrl, email);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse CheckChangePasswordToken(string token)
	{
		CxWSBasicRepsonse result = _web_Service.CheckChangePasswordToken(token);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse ChangePasswordWithToken(string token, string password)
	{
		CxWSBasicRepsonse result = _web_Service.ChangePasswordWithToken(token, password);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse ChangePassword(string sessionID, string oldPsw, string newPsw)
	{
		CxWSBasicRepsonse result = _web_Service.ChangePassword(sessionID, oldPsw, newPsw);
		return result;
	}
	[WebMethod()]
	public CxWSResponseGroupList GetCompanies()
	{
		CxWSResponseGroupList result = _web_Service.GetCompanies();
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse RegisterPendingUser(WebClientPendingUser pendingUser, string pendingUsersTableUrl)
	{
		CxWSBasicRepsonse result = _web_Service.RegisterPendingUser(pendingUser, pendingUsersTableUrl);
		return result;
	}
	[WebMethod()]
	public CxWSResponsePendingUsersList GetPendingUsersList(string sessionID)
	{
		CxWSResponsePendingUsersList result = _web_Service.GetPendingUsersList(sessionID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse DeletePendingUsers(string sessionID, int[] userIdList)
	{
		CxWSBasicRepsonse result = _web_Service.DeletePendingUsers(sessionID, userIdList);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse ApprovePendingUsers(string sessionID, WebClientApprovedUser[] userList)
	{
		CxWSBasicRepsonse result = _web_Service.ApprovePendingUsers(sessionID, userList);
		return result;
	}
	[WebMethod()]
	public CxWSResponseProfileData GetUserProfileData(string sessionID)
	{
		CxWSResponseProfileData result = _web_Service.GetUserProfileData(sessionID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse UpdateUserProfileData(string sessionID, ProfileData userProfileData)
	{
		CxWSBasicRepsonse result = _web_Service.UpdateUserProfileData(sessionID, userProfileData);
		return result;
	}
	[WebMethod()]
	public CxWSResponseUserData GetAllUsers(string sessionID)
	{
		CxWSResponseUserData result = _web_Service.GetAllUsers(sessionID);
		return result;
	}
	[WebMethod()]
	public CxWSResponseUserData GetAllUsersInGroup(string sessionID, string groupID, bool isRecursive)
	{
		CxWSResponseUserData result = _web_Service.GetAllUsersInGroup(sessionID, groupID, isRecursive);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse DeleteUser(string sessionID, int userID)
	{
		CxWSBasicRepsonse result = _web_Service.DeleteUser(sessionID, userID);
		return result;
	}
	[WebMethod()]
	public CxWSResponseHierarchyGroupNodes GetHierarchyGroupTree(string sessionID)
	{
		CxWSResponseHierarchyGroupNodes result = _web_Service.GetHierarchyGroupTree(sessionID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse SetUserActivationState(string sessionID, int userID, bool activationState)
	{
		CxWSBasicRepsonse result = _web_Service.SetUserActivationState(sessionID, userID, activationState);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse AddNewUser(string sessionID, UserData userData)
	{
		CxWSBasicRepsonse result = _web_Service.AddNewUser(sessionID, userData);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse UpdateUserData(string sessionID, UserData userData)
	{
		CxWSBasicRepsonse result = _web_Service.UpdateUserData(sessionID, userData);
		return result;
	}
	[WebMethod()]
	public CxWSResponseServerLicenseData GetServerLicenseData(string sessionID)
	{
		CxWSResponseServerLicenseData result = _web_Service.GetServerLicenseData(sessionID);
		return result;
	}
	[WebMethod()]
	public CxWSResponseUsersLicenseData GetUsersLicenseData(string sessionID, string groupID)
	{
		CxWSResponseUsersLicenseData result = _web_Service.GetUsersLicenseData(sessionID, groupID);
		return result;
	}
	[WebMethod()]
	public CxWSResponseCompaniesLicenseData GetCompaniesLicenseData(string sessionID, string groupID)
	{
		CxWSResponseCompaniesLicenseData result = _web_Service.GetCompaniesLicenseData(sessionID, groupID);
		return result;
	}
	[WebMethod()]
	public CxWSResponseSPLicenseData GetSPLicenseData(string sessionID, string groupID)
	{
		CxWSResponseSPLicenseData result = _web_Service.GetSPLicenseData(sessionID, groupID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse UpdateUserGroups(string sessionID, long userID, Group[] unsubscribedGroups, Group[] subscribedGroups, Role role)
	{
		CxWSBasicRepsonse result = _web_Service.UpdateUserGroups(sessionID, userID, unsubscribedGroups, subscribedGroups, role);
		return result;
	}
	[WebMethod()]
	public CxWSResponseGroupList GetCompaniesList()
	{
		CxWSResponseGroupList result = _web_Service.GetCompaniesList();
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse IsValidUserName(string sessionID, string username)
	{
		CxWSBasicRepsonse result = _web_Service.IsValidUserName(sessionID, username);
		return result;
	}
	[WebMethod()]
	public CxWSResponseNameList GetAvailbleDomainNames(string sessionID)
	{
		CxWSResponseNameList result = _web_Service.GetAvailbleDomainNames(sessionID);
		return result;
	}
	[WebMethod()]
	public CxWSResponseDomainUserList GetAllUsersFromDomain(string sessionID, string domain, string i_SearchPattern)
	{
		CxWSResponseDomainUserList result = _web_Service.GetAllUsersFromDomain(sessionID, domain, i_SearchPattern);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse CreateNewTeam(string sessionID, string parentTeamID, string newTeamName)
	{
		CxWSBasicRepsonse result = _web_Service.CreateNewTeam(sessionID, parentTeamID, newTeamName);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse RenameTeam(string sessionID, string teamID, string newTeamName)
	{
		CxWSBasicRepsonse result = _web_Service.RenameTeam(sessionID, teamID, newTeamName);
		return result;
	}
	[WebMethod()]
	public CxWSResponseTeamData GetAllTeams(string sessionID)
	{
		CxWSResponseTeamData result = _web_Service.GetAllTeams(sessionID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse DeleteTeam(string sessionID, string teamID)
	{
		CxWSBasicRepsonse result = _web_Service.DeleteTeam(sessionID, teamID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse CreateNewCompany(string sessionID, string ParentSP, string newTCompanyName, int companyManagers, int scanners, int reviewers, bool allowActions)
	{
		CxWSBasicRepsonse result = _web_Service.CreateNewCompany(sessionID, ParentSP, newTCompanyName, companyManagers, scanners, reviewers, allowActions);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse CreateNewServiceProvider(string sessionID, string newSpName, int spManagersint, int companyManagers, int scanners, int reviewers)
	{
		CxWSBasicRepsonse result = _web_Service.CreateNewServiceProvider(sessionID, newSpName, spManagersint, companyManagers, scanners, reviewers);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse RenameCompany(string sessionID, string teamID, string newTeamName)
	{
		CxWSBasicRepsonse result = _web_Service.RenameCompany(sessionID, teamID, newTeamName);
		return result;
	}
	[WebMethod()]
	public CxWSResponseTeamData GetAllCompanies(string sessionID)
	{
		CxWSResponseTeamData result = _web_Service.GetAllCompanies(sessionID);
		return result;
	}
	[WebMethod()]
	public CxWSResponseTeamData GetAllSPs(string sessionID)
	{
		CxWSResponseTeamData result = _web_Service.GetAllSPs(sessionID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse DeleteCompany(string sessionID, string teamID)
	{
		CxWSBasicRepsonse result = _web_Service.DeleteCompany(sessionID, teamID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse DeleteSP(string sessionID, string teamID)
	{
		CxWSBasicRepsonse result = _web_Service.DeleteSP(sessionID, teamID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse IsValidCompanyName(string sessionID, string companyName, string serviceProviderID)
	{
		CxWSBasicRepsonse result = _web_Service.IsValidCompanyName(sessionID, companyName, serviceProviderID);
		return result;
	}
	[WebMethod()]
	public CxWSResponseTeamData GetCompanyTeams(string sessionID, string companyID)
	{
		CxWSResponseTeamData result = _web_Service.GetCompanyTeams(sessionID, companyID);
		return result;
	}
	[WebMethod()]
	public CxWSResponseTeamData GetServiceProviderTeams(string sessionID, string spID)
	{
		CxWSResponseTeamData result = _web_Service.GetServiceProviderTeams(sessionID, spID);
		return result;
	}
	[WebMethod()]
	public CxWSResponseTeamData GetServiceProviderCompanies(string sessionID, string spID)
	{
		CxWSResponseTeamData result = _web_Service.GetServiceProviderCompanies(sessionID, spID);
		return result;
	}
	[WebMethod()]
	public CxWsResponseCompanyProperties GetCompanyProperties(string sessionID, string companyID)
	{
		CxWsResponseCompanyProperties result = _web_Service.GetCompanyProperties(sessionID, companyID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse SetUserAsCompanyManager(string sessionID, string companyID, long userID)
	{
		CxWSBasicRepsonse result = _web_Service.SetUserAsCompanyManager(sessionID, companyID, userID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse SetUserAsServiceProviderManager(string sessionID, string spID, long userID)
	{
		CxWSBasicRepsonse result = _web_Service.SetUserAsServiceProviderManager(sessionID, spID, userID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse IsValidServiceProviderName(string sessionID, string serviceProviderName)
	{
		CxWSBasicRepsonse result = _web_Service.IsValidServiceProviderName(sessionID, serviceProviderName);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse UpdateCompanyProperties(string sessionID, string companyID, string companyName, int maxReviewers, int maxScanners, int maxManagers)
	{
		CxWSBasicRepsonse result = _web_Service.UpdateCompanyProperties(sessionID, companyID, companyName, maxReviewers, maxScanners, maxManagers);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse SetSystemSettings(string sessionID, SystemSettings settings)
	{
		CxWSBasicRepsonse result = _web_Service.SetSystemSettings(sessionID, settings);
		return result;
	}
	[WebMethod()]
	public CxWSResponseSystemLanguages GetServerLanguageList(string sessionID)
	{
		CxWSResponseSystemLanguages result = _web_Service.GetServerLanguageList(sessionID);
		return result;
	}
	[WebMethod()]
	public CxWsResponseSystemSettings GetSystemSettings(string sessionID)
	{
		CxWsResponseSystemSettings result = _web_Service.GetSystemSettings(sessionID);
		return result;
	}
	[WebMethod()]
	public CxWSBasicRepsonse VerifySupportedVersion(CxClientType clientType, string clientVersion, string APIVersion)
	{
		CxWSBasicRepsonse result = _web_Service.VerifySupportedVersion(clientType, clientVersion, APIVersion);
		return result;
	}
	[WebMethod()]
	public CxWSResponseInstallationSettings GetInstallationSettings(string sessionID)
	{
		CxWSResponseInstallationSettings result = _web_Service.GetInstallationSettings(sessionID);
		return result;
	}
	[WebMethod()]
	public CxWSResponsePresetList GetPresetList(string SessionID)
	{
		CxWSResponsePresetList result = _web_Service.GetPresetList(SessionID);
		return result;
	}
}
