	Qva.AddDocumentExtension('NavigationLog', function () {	

		$("div[class^='QvFrame Document_TX']").click(function() { 
  			
  			var  osUser, obj= $(this).attr("class"), 
  			tobj = qva.GetQvObject("txUserId", function () {
      		osUser = tobj.QvaPublic.GetText();

	  			var param = {user:  osUser, obj: obj};
				$.ajax({
				url: "/QvAjaxZfc/Log.aspx/WriteLog",
				data: JSON.stringify(param),
				dataType: "json",
				type: "POST",
				contentType: "application/json; charset=utf-8",
				success: function (data) {
				
				},
				error: function (XMLHttpRequest, textStatus, errorThrown) {

				}
				});
			});

		});
	});
