﻿namespace chocolatey.infrastructure.app.commands
{
    using System.ComponentModel;

    public enum CommandNameType
    {
        [Description("list - lists remote or local packages")]
        list,
        [Description("search - searches remote or local packages")]
        search,
        [Description("install - installs packages from various sources")]
        install,
        //[Description("update - updates package index")]
        //update,
        [Description("upgrade - upgrades packages from various sources")]
        upgrade,
        [Description("uninstall - uninstalls a package")]
        uninstall,
        [Description("sources - view and configure default sources")]
        sources,
        [Description("config - view and change configuration")]
        config
    }
}