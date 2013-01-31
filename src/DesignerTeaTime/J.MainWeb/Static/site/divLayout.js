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
			bodyOffset = $body.offset(),
			MaxHeight = 0;

		for (var i = 0, len = postions.length; i < len; i++)
		{
			var d = postions[i],
				$d = $("#" + d.id, $body),
				dOffset = $d.offset(),
				tempMaxHeight = d.top + $d.outerHeight();

			if (MaxHeight < tempMaxHeight)
				MaxHeight = tempMaxHeight;

			$d.css({ position: "relative", top: bodyOffset.top - dOffset.top + d.top, left: bodyOffset.left - dOffset.left + d.left });
		}

		$body.css("height", MaxHeight);
	}
});