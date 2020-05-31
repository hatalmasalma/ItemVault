using Rocket.API;
using System;

namespace fr34kyn01535.ItemVault
{
    public class ItemVaultConfiguration : IRocketPluginConfiguration
    {
        public string DatabaseAddress;
        public string DatabasePort;
        public string DatabaseUsername;
        public string DatabasePassword;
        public string DatabaseName;
        public string DatabaseTableName;
        public bool Enabled;

        public void LoadDefaults()
        {
            DatabaseAddress = "localhost";
            DatabasePort = "3306";
            DatabaseUsername = "unturned";
            DatabasePassword = "password";
            DatabaseName = "unturned";
            DatabaseTableName = "itemvault";
            Enabled = true;
        }
    }
}