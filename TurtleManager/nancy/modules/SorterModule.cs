using System.Collections.Generic;
using System.Linq;
using Nancy;
using NLog;
using TurtleManager.sections.sorter;

namespace TurtleManager.nancy.modules {
	public class SorterModule : NancyModule {
		private readonly Logger logger = LogManager.GetCurrentClassLogger();

		public SorterModule() {
			Get["/sorter"] = parameters => {
				logger.Debug("/sorter path was called");
				Dictionary<string, object> attributes = Request.Query.ToDictionary();
				if (attributes == null || attributes.Count == 0) {
					logger.Error("no attributes sent in /sorter request");
					return Response.AsText("ERROR", "text/plain");
				}
				if (!attributes.Keys.Contains("id")) {
					logger.Error("no id attribute in /sorter request");
					return Response.AsText("ERROR", "text/plain");
				}
				string itemId = (string) attributes["id"];
				logger.Debug("got request for id: " + itemId);
				return Response.AsText(ItemData.GetListNameForItem(itemId), "text/plain");
			};
		}
	}
}
