#if UNITY_5_3_OR_NEWER
#define NOESIS
using Noesis;
#else
using System;
using System.Windows.Controls;
#endif

namespace FirstNoesis
{
    /// <summary>
    /// Interaction logic for FirstNoesisMainView.xaml
    /// </summary>
    public partial class FirstNoesisMainView : UserControl
    {
        public FirstNoesisMainView()
        {
            InitializeComponent();
        }

#if NOESIS
        private void InitializeComponent()
        {
            NoesisUnity.LoadComponent(this);
        }
#endif
    }
}
