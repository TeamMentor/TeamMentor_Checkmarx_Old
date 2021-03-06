TM.Gui.AppliedFilters.currentPivotPanelFilters = new Array(); 

TM.Gui.AppliedFiltersList.removeFilters = function()
	{		        
		TM.Gui.AppliedFilters.currentFilters = [];
		TM.Gui.AppliedFilters.currentPivotPanelFilters = new Array(); 
		TM.Events.onInvalidateSearchText();
		if (window.location.hash.length > 1)
			window.location.hash = "";
		else
		{
			TM.Gui.AppliedFiltersList.populateAppliedFiltersTable() ;				
			TM.Events.onFiltersRemoved();
		}
	}

TM.Gui.AppliedFiltersList.removeCriteraFromCriteriaCollection = function(text,title, column, state)
	{		
		setPivotPanelFilter(text, title, column, false, false, true);			
		TM.Events.onTextSearch()
	}
	
TM.Gui.AppliedFiltersList.clear_FiltersGui = function()
	{
		$("#AppliedFilterItems").html('');
	}
	
TM.Gui.AppliedFiltersList.add_Filter = function(text, title, column, showButtons, pinned)
	{
		var filterDiv = 	  $("<div class='AppliedFilterItem'>");
		var deleteImg = 	  $("<img src='/Images/DeleteFilterIcon.png' alt='Delete Filter' class='DeleteButton' />");
		var filterItemImage = $("<img id='ctl00_ContentPlaceHolder1_AppliedFilters1_AppliedFiltersListView_ctrl0_Image1' src='/Images/SingleLibrary.png' style='border-width:0px;' />"); 
        var pinnedImg       = $("<img class='PinButton'/>");
        //var unPinnedImg       = $("<img src='/Images/unPinned.png' alt='UnPin item' = Database Security' class='PinButton' style='width:15px'/>");
		//filterItemText  = $("<span id='ctl00_ContentPlaceHolder1_AppliedFilters1_AppliedFiltersListView_ctrl0_Label1'>");
		
		filterItemText = $("<span>").append(" {0} = {1}".format(htmlEscape(title), htmlEscape(text)));		

        //handle delete button settings
        
		deleteImg.click(function()
			{
             /*   if (pinnedImg.pinned)			
                    TM.Gui.Dialog.alertUser("You can't remove a pinned filter (please unpin it first)")
                else	*/  
                if (pinnedImg.pinned)		        // if it is pinned we need to unpin it first
                    pinnedImg.click();
                    //TM.Gui.AppliedFiltersList.handle_PinChange(text, title, pinnedImg);
				TM.Gui.AppliedFiltersList.removeCriteraFromCriteriaCollection(text, title, column, false);
			})

        //handle pin button settings
        pinnedImg.click(function()
            {
                TM.Gui.AppliedFiltersList.handle_PinChange(text, title, pinnedImg);
            });
		TM.Gui.AppliedFiltersList.set_Pinned(pinnedImg, pinned);

        //add all elements that make this fileter
        filterDiv.append(filterItemImage);        
		filterDiv.append(filterItemText);
        
        
		if(showButtons)
        {
			filterDiv.append(deleteImg)		
            filterDiv.append(pinnedImg);
        }
        
		$("#AppliedFilterItems").append(filterDiv);
	}

TM.Gui.AppliedFiltersList.handle_PinChange = function(text, title, pinnedImg)
    {
        pinnedImg.pinned = !pinnedImg.pinned;
        TM.Gui.AppliedFiltersList.set_Pinned(pinnedImg, pinnedImg.pinned);
        var hashCommand= title + ":" + text;
        var newHash = "#";
        newHash += (pinnedImg.pinned) ?  hashCommand : "";        
        $.each(document.location.hash.substring(1).split("&"), function(index,value)
            {                
                if (value != hashCommand && value !="")
                    newHash += ((newHash === "#") ? "" : "&") + value;
            });                
        TM.Gui.Main.Panels.handleWindowHashChange = false;
        document.location.hash = newHash;                
    }

TM.Gui.AppliedFiltersList.set_Pinned = function(pinnedImg, pinned)
    {        
        if (pinned)
            pinnedImg.attr('src', '/Images/Pinned.png').width('19px').pinned = true;
        else
            pinnedImg.attr('src', '/Images/unPinned.png').width('14px').pinned=false;
    }

TM.Gui.AppliedFiltersList.populateAppliedFiltersTable = function ()
{		

	if (isUndefined(TM.Gui.selectedNodeData))
		return;
	TM.Gui.AppliedFiltersList.clear_FiltersGui();

	
	$.each(TM.Gui.AppliedFilters.currentPivotPanelFilters, function()
		{			
			TM.Gui.AppliedFiltersList.add_Filter(this.text, this.title, this.column, true, this.pinned);
		})
		
	if (TM.Gui.DataTable.currentTextFilter != "") //escape
		TM.Gui.AppliedFiltersList.add_Filter(htmlEscape(TM.Gui.DataTable.currentTextFilter), 'Search', -1 , false, true);
		
	TM.Gui.AppliedFiltersList.fixCSS_appliedFilters();
}

TM.Gui.AppliedFiltersList.fixCSS_appliedFilters = function()
{	
	try
	{
		if ( $.browser.msie )
		{
			//"AppliedFilterHeader".$().height(32);		
			"AppliedFilterHeader".$().height(26);
			"ctl00_ContentPlaceHolder1_AppliedFilters1_RemoveFiltersImage".$()
				.absolute()
				.right(0)
				.top(5);
		}
		$("#AppliedFiltersPanel").width("97%")	
		/*}	
		else
		{
			"AppliedFiltersPanel".$().width('95%');
		}*/
	}
	catch(message) {}	
}



function htmlEscape(str) 
{
    return String(str)
            .replace(/&/g, '&amp;')
            .replace(/"/g, '&quot;')
            .replace(/'/g, '&#39;')
            .replace(/</g, '&lt;')
            .replace(/>/g, '&gt;');
}