
using System;
using System.Threading;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DynamicPatcher;
using PatcherYRpp;
using Extension.Ext;

namespace ExtensionHooks
{
    public class CreditExtHook
    {
        // [Hook(HookType.AresHook, Address = 0x4A25E0, Size = 7)]
        public static unsafe UInt32 CreditsClass_GraphicLogic(REGISTERS* R)
        {
            Kratos.DrawActiveMessage();
            PrintTextManager.PrintText();
            return (uint)0;
        }
    }
}

