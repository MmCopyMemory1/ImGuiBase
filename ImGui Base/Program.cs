using System;
using System.Threading;
using System.Threading.Tasks;
using ImGuiNET;

namespace BaseGui
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseRender render = new BaseRender(); // BaseRender->Render instance
            new Thread(() =>
            {
                render.Start().GetAwaiter().GetResult(); //Starts Render.
            })
            { IsBackground = true }.Start();

            //ImGuiMemory.BaseMem.BaseWriteToMem()

            Console.ReadLine(); 
        }

    }
}