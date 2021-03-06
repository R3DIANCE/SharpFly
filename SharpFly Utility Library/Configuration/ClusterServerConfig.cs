﻿namespace SharpFly_Utility_Library.Configuration
{
    public class ClusterServerConfig : Config
    {
        public ClusterServerConfig(string path) : base(path)
        {
            base.Read("MySQLAddress", "Address", "MySQL", typeof(string));
            base.Read("MySQLUsername", "Username", "MySQL", typeof(string));
            base.Read("MySQLPassword", "Password", "MySQL", typeof(string));
            base.Read("MySQLDatabaseLogin", "DatabaseLogin", "MySQL", typeof(string));
            base.Read("MySQLDatabaseCluster", "DatabaseCluster", "MySQL", typeof(string));
            base.Read("MySQLPort", "Port", "MySQL", typeof(int));
            base.Read("ClusterAuthorizationPassword", "ClusterAuthorizationPassword", "Security", typeof(string));
            base.Read("ClientBuildDate", "ClientBuildDate", "Security", typeof(string));
            base.Read("Address", "Address", "Cluster", typeof(string));
            base.Read("ClusterPort", "ClusterPort", "Cluster", typeof(int));
            base.Read("ClusterId", "ClusterId", "Cluster", typeof(uint));
            base.Read("LoginAddress", "LoginAddress", "Cluster", typeof(string));
            base.Read("LoginPort", "LoginPort", "Cluster", typeof(int));
            base.Read("ClusterStartPort", "ClusterStartPort", "Cluster", typeof(int));
        }
    }
}
