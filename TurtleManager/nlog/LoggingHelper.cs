using System;
using System.Deployment.Application;
using System.Linq;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace TurtleManager.nlog {
	public class LoggingHelper {
		public static void SetupConfiguration() {
			LoggingConfiguration logConfig = new LoggingConfiguration();

			FileTarget fileTarget = new FileTarget {
				FileName = "turtleManager.log",
				ArchiveFileName = "turtleManager.{#}.log",
				ArchiveOldFileOnStartup = true,
				ArchiveNumbering = ArchiveNumberingMode.Rolling,
				MaxArchiveFiles = 5,
				ConcurrentWrites = true,
				KeepFileOpen = false,
				Layout = @"${date:format=HH\:mm\:ss.fff} [${level}] ${logger} - ${message}"
			};
			logConfig.AddTarget("file", fileTarget);
			LoggingRule rule = new LoggingRule("*", LogLevel.Debug, fileTarget);
			logConfig.LoggingRules.Add(rule);

			LogManager.Configuration = logConfig;
			LogManager.DisableLogging();

			bool isNetworkAppDebug = false;
			if (ApplicationDeployment.IsNetworkDeployed) {
				string[] args = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData;
				if (args != null && args.Length > 0) {
					isNetworkAppDebug = args[0].ToLower().Equals("debug");
				}
			}

			if (Environment.GetCommandLineArgs().Contains("debug") || isNetworkAppDebug) {
				LogManager.EnableLogging();
			}
		}
	}
}
