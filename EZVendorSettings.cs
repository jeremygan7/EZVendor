﻿using System.Windows.Forms;
using ExileCore.Shared.Attributes;
using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;

namespace EZVendor
{
    public class EZVendorSettings : ISettings
    {
        [Menu("Chaos Unique Cutoff")]
        public RangeNode<int> ChaosUniqueCutoff { get; set; } = new RangeNode<int>(10, 1, 30);

        [Menu("Sell garbage hotkey")] 
        public HotkeyNode MainHotkey { get; set; } = new HotkeyNode(Keys.F3);

        [Menu("Stop hotkey")] 
        public HotkeyNode StopHotkey { get; set; } = new HotkeyNode(Keys.Escape);

        [Menu("Debug copy inventory item stats under cursor hotkey")]
        public HotkeyNode CopyStatsHotkey { get; set; } = new HotkeyNode(Keys.NumPad7);

        [Menu("Auto click TANE to trade (enable for auto sell)")]
        public ToggleNode AutoOpenTrade { get; set; } = new ToggleNode(true);

        [Menu("Auto click sell window accept button (enable for auto sell)")]
        public ToggleNode AutoClickAcceptButton { get; set; } = new ToggleNode(true);
        
        [Menu("Vendor influenced gear (enable for auto sell)")]
        public ToggleNode VendorInfluenced { get; set; } = new ToggleNode(true);

        [Menu("Click cancel button instead (for debug)")]
        public ToggleNode AutoClickDebug { get; set; } = new ToggleNode(false);

        [Menu("Vendor transmutes")]
        public ToggleNode VendorTransmutes { get; set; } = new ToggleNode(true);
        
        [Menu("Vendor scraps/whetstones")]
        public ToggleNode VendorScraps { get; set; } = new ToggleNode(true);
       
        [Menu("Less garbage (enable after first week of league)")]
        public ToggleNode StricterFiltering { get; set; } = new ToggleNode(true);
        
        [Menu("Sell all 6 links")]
        public ToggleNode Sell6Links { get; set; } = new ToggleNode(false);
        
        [Menu("Vendor all rares")]
        public ToggleNode VendorAllRares { get; set; } = new ToggleNode(false);

        [Menu("Bypass broken ItemMods component (debug)")]
        public ToggleNode BypassBrokenItemMods { get; set; } = new ToggleNode(false);
        
        [Menu("Extra log (for debug)")] 
        public ToggleNode DebugLog { get; set; } = new ToggleNode(false);

        public ToggleNode Enable { get; set; } = new ToggleNode(false);
        
        public string LeagueName3 = "Ultimatum";
        
        [Menu("Delay after mouse move")]
        public RangeNode<int> Delay1AfterMouseMove { get; set; } = new RangeNode<int>(5, 0, 100);
        
        [Menu("Delay after click")]
        public RangeNode<int> Delay2AfterClick { get; set; } = new RangeNode<int>(25, 0, 100);
    }
}