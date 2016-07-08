using System;
using Nancy.Hosting.Self;
using NLog;

namespace TurtleManager.nancy {
	public class NancyHelper {
		private static readonly Logger logger = LogManager.GetCurrentClassLogger();
		private static NancyHost host;
		private const int PORTNUMBER = 567;

		public static void StartHost() {
			logger.Debug("starting nancy host on port: "+PORTNUMBER);
			host = new NancyHost(new Uri("http://localhost:" + PORTNUMBER));
			host.Start();
			logger.Debug("host started");
		}

		public static void StopHost() {
			logger.Debug("stopping nancy host");
			host.Stop();
			logger.Debug("host stopped");
		}
	}
}
