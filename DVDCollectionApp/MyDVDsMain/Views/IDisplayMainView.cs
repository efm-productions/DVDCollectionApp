using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Gnr.Dialogs;
using nspIcon.Dialogs;
using Rt.Dialogs;

namespace MyDVDsMain.Views
{
    public interface IDisplayMainView
    {
        // Events
        event EventHandler OnViewLoad;
        event EventHandler OnViewDetailesClicked;
        event EventHandler OnSelectBoxViewEditClicked;
        event EventHandler OnStartNewBoxClicked;
        event EventHandler OnSearchTitleClicked;
        event EventHandler OnClearClicked;
        event EventHandler OnbtnIconsClick;
        event EventHandler OnbtnGenresClick;
        event EventHandler OnbtnRatingsClick;
        event EventHandler OnbtnCloseClick;

        // Grid
        DataGridView gridAllContents { get; set; }

        // controls
        ComboBox BoxNumbersCombo { get; }
        Control ActvCtrl { get; set; }

        // methods
        void ShowView();
        void HideView();
        void CloseView();
        void ShowMessage(string message, string title, MessageBoxButtons b, MessageBoxIcon i);

        // properties
        string BoxNumbersComboText { get; set; }
        string v_totalBoxes { get; set; }
        string v_totalCases { get; set; }
        string v_totalBoxsets { get; set; }
        string v_totalDiscs { get; set; }
        string v_totalContents { get; set; }
        DataGridView TheGrid { get; }
        string SearchTextBox { get; set; }

        // navigation
        DisplayIcons CreateDisplayIcons();
        DisplayGenres CreateDisplayGenres();
        DisplayRatings CreateDisplayRatings();
    }
}
