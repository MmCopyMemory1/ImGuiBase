using ImGuiNET;
using System.Numerics;
using System.Drawing;

namespace ImGuiNotify
{
    public class Drawing
    {
        public static void DrawNotify(Vector2 position, Vector2 size, Color color, string title, string message)
        {
            Vector4 imguiColor = new Vector4(color.R / 255f, color.G / 255f, color.B / 255f, color.A / 255f);

            ImGui.SetNextWindowPos(position, ImGuiCond.Always);
            ImGui.SetNextWindowSize(size, ImGuiCond.Always);

            ImGui.PushStyleColor(ImGuiCol.WindowBg, imguiColor);

            ImGui.Begin($"##Notify_{title}", ImGuiWindowFlags.NoTitleBar | ImGuiWindowFlags.AlwaysAutoResize | ImGuiWindowFlags.NoMove | ImGuiWindowFlags.NoSavedSettings);

            ImGui.TextColored(new Vector4(1, 1, 1, 1), title);
            ImGui.Separator();
            ImGui.TextWrapped(message);

            ImGui.End();
            ImGui.PopStyleColor();
        }
    }
}
