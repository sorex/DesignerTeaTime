/// <reference path="../jquery/jquery-1.9.0.intellisense.js" />

jQuery.fn.extend({
	divLayout: function (postions)
	{
		//var postions = [
		//	{ id: "A", top: 0, left: 0 },
		//	{ id: "B", top: 0, left: 55 },
		//	{ id: "C", top: 25, left: 0 },
		//	{ id: "D", top: 110, left: 0 },
		//	{ id: "E", top: 110, left: 105 }
		//];

		var $body = $(this),
			MaxHeight = 0;

		for (var i = 0, len = postions.length; i < len; i++)
		{
			var d = postions[i],
				$d = $("#" + d.id, $body),
				tempMaxHeight = d.top + $d.outerHeight();

			if (MaxHeight < tempMaxHeight)
				MaxHeight = tempMaxHeight;

			$d.css({ position: "absolute", top: d.top, left: d.left });
		}

		$body.css("height", MaxHeight);
	}
});

jQuery.extend({
	formValueString:function(ids)
	{
		var valueList = [];
		for (var i = 0; i < ids.length; i++)
		{
			var id = ids[i];
			var $self = $("#" + id);

			if ($self.length == 0)
				throw "DOM 中不存在ID为 [" + id + "] 的元素。";
			else if ($self.length > 1)
				throw "DOM 中存在" + $self.length + "个ID为 [" + id + "] 的元素。";
			else
			{
				var $element = $self[0];
				switch ($element.nodeName.toLowerCase())
				{
					case "input":
						switch ($element.attr("type"))
						{
							case "text":
								break;
							case "password":
								break;
							case "radio":
								break;
							case "checkbox":
								break;
							case "submit":
								break;
							case "image":
								break;
							case "reset":
								break;
							case "button":
								break;
							case "file":
								break;
							case "hidden":
								break;
							default:
								break;
						}
						break;
					case "select":
						break;
					case "textarea":
						break;
					default:
						break;
				}
			}
		}
	}
});