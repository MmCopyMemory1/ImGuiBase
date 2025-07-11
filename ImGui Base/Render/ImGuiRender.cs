using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImGuiNET;
using ClickableTransparentOverlay;
using System.Numerics;
using System.Runtime.InteropServices.Marshalling;

/*
	Create By Kyuubi.
	Credits; Pluto For Idea.
	If you want, add to it then release!
	If you add something credit yourself.
*/

namespace BaseGui
{
    public class BaseRender : Overlay
    {
        StreamWriter writer = new StreamWriter("Base.txt");
        protected override void Render()
        {
            Vector2 windowSize = new Vector2(120f, 120f); // <-- wSize
            Vector2 windowPos = new Vector2(20f, 20f); // <-- wPos
            Vector2 notifyPos = new Vector2(0, ImGui.GetIO().DisplaySize.Y - 100); // Bottom-left
            Vector2 notifySize = new Vector2(300, 100); // Width x Height


            ImGui.SetWindowSize(windowSize, ImGuiCond.FirstUseEver); //Set them.
            ImGui.SetWindowPos(windowPos, ImGuiCond.FirstUseEver);

            // Render UI.

            if(ImGui.Begin("Base"))
            {
                writer.WriteLine("[ Sucess ] -> Loaded [ImGui.Begin]\n");
                writer.Close();
                ImGui.End();
                ImGuiNotify.Drawing.DrawNotify(notifyPos, notifySize,  System.Drawing.Color.Black, "Test", "Test");
               
            } else
            {
                writer.WriteLine("[Failed] -> Error [ImGui.Begin]\n");
                writer.Close();
            }
        }

    }
}
