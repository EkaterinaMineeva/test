using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lib
{
    
    public interface IPlugin
    {
        string PluginName { get; }
        string Version { get; }
        System.Drawing.Image Image { get; }
        string Description { get; }
        int Run(int input1, int input2);
    }

    static class Plugins
    {
        public static int number = 0;

        interface PluginFactory
        {
            int PluginsCount { get; }
            string[] GetPluginNames { get; }
            IPlugin GetPlugin (string pluginName);
        }
        

        private abstract class Int_Methods : IPlugin
        {
            string IPlugin.PluginName => "Test";
            string IPlugin.Version => "1";
            System.Drawing.Image IPlugin.Image => System.Drawing.Image.FromFile("DS_logo - 01.png");
            string IPlugin.Description => "test from the company";
            int IPlugin.Run(int input1, int input2)
            {
                int result = 0;
                string sign = Console.ReadLine();
                if(sign == "+")
                {
                    result = input1 + input2;
                }
                if (sign == "-")
                {
                    result = input1 + input2;
                }
                if (sign == "*")
                {
                    result = input1 + input2;
                }
                if (sign == "Pow")
                {
                    result = (int)Math.Pow(input1, input2);
                }
                return result;
            }


        }
        private class IntMethods : IPlugin
        {
            string IPlugin.PluginName => "Test";
            string IPlugin.Version => "2";
            System.Drawing.Image IPlugin.Image => System.Drawing.Image.FromFile("DS_logo - 01.png");
            string IPlugin.Description => "test from the company";
            int IPlugin.Run(int input1, int input2)
            {
                int result = 0;
                string sign = Console.ReadLine();
                if (sign == "+")
                {
                    result = input1 + input2;
                }
                if (sign == "-")
                {
                    result = input1 + input2;
                }
                if (sign == "*")
                {
                    result = input1 + input2;
                }
                if (sign == "Pow")
                {
                    result = (int)Math.Pow(input1, input2);
                }
                return result;
            }


        }
        private abstract class PluginFactoryMethods : PluginFactory
        {
            int PluginFactory.PluginsCount => 2;
            string[] PluginFactory.GetPluginNames { get; }
            IPlugin PluginFactory.GetPlugin(string pluginName)
            {              
                IPlugin result = new IntMethods();
                return result;
            }
        }
    }

}
