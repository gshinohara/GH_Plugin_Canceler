using Eto.Forms;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace GH_Plugin_Canceler
{
    internal class CancelSelector : Dialog<ResultOfCanceler>
    {
        private Label m_LabelCounting = new Label();

        public CancelSelector(Assembly assembly)
        {
            Width = 250;
            Padding = 5;
            AutoSize = true;
            Topmost = true;

            DynamicLayout layout = new DynamicLayout
            {
                Padding = 15,
                Spacing = new Eto.Drawing.Size(5, 10),
            };
            Content = layout;

            layout.AddSeparateRow(new Label { Text = $"Do you want to load {assembly.GetName().Name} plug-in?", Wrap = WrapMode.Word });
            layout.AddSeparateRow(m_LabelCounting);

            Button button_Yes = new Button((s, e) => Close(ResultOfCanceler.NoProblem)) { Text = "Yes", Width = 90 };
            Button button_No = new Button((s, e) => Close(ResultOfCanceler.ShouldBeCanceled)) { Text = "No", Width = 90 };
            layout.AddSeparateRow(button_Yes, null, button_No);
        }

        protected override async void OnShown(EventArgs e)
        {
            base.OnShown(e);

            int count = 20;
            for (int i = 0; i < count; i++)
            {
                m_LabelCounting.Text = $"If you wait for {count - i} seconds, the plug-in is loaded.";
                await Task.Delay(1000);
            }
            Close(ResultOfCanceler.NoProblem);
        }
    }
}
