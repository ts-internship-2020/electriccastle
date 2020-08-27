using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;

namespace ColorButton
{
	public class ColorButtonDesigner : System.Windows.Forms.Design.ControlDesigner
	{
		public ColorButtonDesigner()
		{
		}

		protected override void PostFilterProperties(IDictionary Properties)
		{
			Properties.Remove("AllowDrop");
			Properties.Remove("BackColor");
			Properties.Remove("BackgroundImage");
			Properties.Remove("ContextMenu");
			Properties.Remove("FlatStyle");
			Properties.Remove("Image");
			Properties.Remove("ImageAlign");
			Properties.Remove("ImageIndex");
			Properties.Remove("ImageList");
			Properties.Remove("TextAlign");
			Properties.Remove("Enabled");
		}
	}
}
