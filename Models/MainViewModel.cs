using ConscriptFinder.Logic;
using ConscriptFinder.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConscriptFinder.States;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.CodeDom;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Collections;
using System.Windows;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System.IO;

namespace ConscriptFinder.Models
{
    public class MainViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        public MainView View;

        private string _conscriptLastName;

        public List<string> RVKList
        {
            get
            {
                Config.RVKList.Sort();
                return Config.RVKList;
            }
        }   

        public List<string> ConscriptList
        {
            get
            {
                return Config.ConscriptList.Keys.ToList();
            }
        }

        public List<string> StationsList
        {
            get
            {
                Config.StationList.Sort();
                return Config.StationList;
            }
        }

        public List<string> MilKinds
        {
            get
            {
                return Config.MilKinds;
            }
        }

        private List<Conscript> _printList = new List<Conscript>(); 

        public List<Conscript> PrintList
        {
            get
            {
                return _printList;
            }

            set
            {
                if(_printList !=  value)
                {
                    _printList = value;
                }
            }
        }

        public string ConscriptLastName
        {
            get
            {
                return _conscriptLastName;
            }

            set
            {
                if(_conscriptLastName != value)
                {
                    if (value != null)
                    {
                        if (value != "")
                        {
                            _conscriptLastName = value.Substring(0, 1).ToUpper();
                            _conscriptLastName += value.Substring(1, value.Length - 1).ToLower();
                        }
                        else
                            _conscriptLastName = value;
                        ShowConscriptsList();
                        HideConscriptCommandsList();
                        ClearConscriptCommandFields();
                    }
                    else
                    {
                        _conscriptLastName = value;
                    }
                }
            }
        }

        private string _conscriptFirstName;

        public string ConscriptFirstName
        {
            get
            {
                return _conscriptFirstName;
            }

            set
            {
                if (_conscriptFirstName != value)
                {
                    if(value != null)
                    {
                        if(value != "")
                        {
                            _conscriptFirstName = value.Substring(0, 1).ToUpper();
                            _conscriptFirstName += value.Substring(1, value.Length - 1).ToLower();
                        }
                        else 
                            _conscriptFirstName = value;
                        ShowConscriptsList();
                        HideConscriptCommandsList();
                        ClearConscriptCommandFields();
                    }
                    else
                    {
                        _conscriptFirstName = value;
                    }
                }
            }
        }

        private string _conscriptMiddleName;

        public string ConscriptMiddleName
        {
            get
            {
                return _conscriptMiddleName;
            }

            set
            {
                if (_conscriptMiddleName != value)
                {
                    if(value != null)
                    {
                        if(value != "")
                        {
                            _conscriptMiddleName = value.Substring(0, 1).ToUpper();
                            _conscriptMiddleName += value.Substring(1, value.Length - 1).ToLower();
                        } 
                        else 
                            _conscriptMiddleName = value;
                        ShowConscriptsList();
                        HideConscriptCommandsList();
                        ClearConscriptCommandFields();
                    } 
                    else
                    {
                        _conscriptMiddleName = value;
                    }
                }
            }
        }

        private DateTime? _conscriptBirthDate = null;

        public DateTime? ConscriptBirthDate
        {
            get
            {
                return _conscriptBirthDate;
            }

            set
            {
                if( _conscriptBirthDate != value)
                {
                    if(value != null)
                    {
                        ShowConscriptsList();
                        HideConscriptCommandsList();
                        ClearConscriptCommandFields();
                    }
                    _conscriptBirthDate = value;
                }
            }
        }

        private string _conscriptPassportSeries;

        public string ConscriptPassportSeries
        {
            get
            {
                return _conscriptPassportSeries;
            }

            set
            {
                if (_conscriptPassportSeries != value)
                {
                    if(value != null)
                    {
                        ShowConscriptsList();
                        HideConscriptCommandsList();
                        ClearConscriptCommandFields();
                    }
                    _conscriptPassportSeries = value;
                }
            }
        }

        private string _conscriptPassportNumber;

        public string ConscriptPassportNumber
        {
            get
            {
                return _conscriptPassportNumber;
            }

            set
            {
                if (_conscriptPassportNumber != value)
                {
                    if (value != null)
                    {
                        ShowConscriptsList();
                        HideConscriptCommandsList();
                        ClearConscriptCommandFields();
                    }
                    _conscriptPassportNumber = value;
                }
            }
        }

        private string _conscriptMilitaryTicketSeries;

        public string ConscriptMilitaryTicketSeries
        { 
            get
            {
                return _conscriptMilitaryTicketSeries;
            }

            set
            {
                if(_conscriptMilitaryTicketSeries != value)
                {
                    if (value != null)
                    {
                        ShowConscriptsList();
                        HideConscriptCommandsList();
                        ClearConscriptCommandFields();
                    }
                    _conscriptMilitaryTicketSeries = value;
                }
            }
        }

        private string _conscriptMilitaryTicketNumber;

        public string ConscriptMilitaryTicketNumber
        {
            get
            {
                return _conscriptMilitaryTicketNumber;
            }

            set
            {
                if(_conscriptMilitaryTicketNumber != value)
                {
                    if (value != null)
                    {
                        ShowConscriptsList();
                        HideConscriptCommandsList();
                        ClearConscriptCommandFields();
                    }
                    _conscriptMilitaryTicketNumber = value;
                }
            }
        }

        private string _conscriptRVK;

        public string ConscriptRVK
        {
            get
            {
                return _conscriptRVK;
            }

            set
            {
                if(_conscriptRVK != value)
                {
                    if (value != null)
                    {
                        ShowConscriptsList();
                        HideConscriptCommandsList();
                        ClearConscriptCommandFields();
                    }
                    _conscriptRVK = value;
                }
            }
        }

        private string _conscript;

        public string Conscript
        {
            get
            {
                return _conscript;
            }

            set
            {
                if(_conscript != value)
                {
                    if (value != null)
                    {
                        ShowConscriptsList();
                        HideConscriptCommandsList();
                        ClearConscriptCommandFields();
                    }
                    _conscript = value;
                }
            }
        }

        private ObservableCollection<Conscript> _conscriptsList = new ObservableCollection<Conscript>();

        public ObservableCollection<Conscript> ConscriptsList
        {
            get
            {
                return _conscriptsList;
            }

            set
            {
                if(_conscriptsList != value)
                    _conscriptsList = value;
            }
        }

        private ObservableCollection<ConscriptCommand> _conscriptCommandsList = new ObservableCollection<ConscriptCommand>();

        public ObservableCollection <ConscriptCommand> ConscriptCommandsList
        {
            get 
            {
                return _conscriptCommandsList;
            } 

            set
            {
                if(_conscriptCommandsList != value)
                    _conscriptCommandsList = value;
            }
        }

        private string _conscriptsListVisibility = "Visible";

        public string ConscriptsListVisibility
        {
            get
            {
                return _conscriptsListVisibility;
            }

            set
            {
                if(_conscriptsListVisibility != value)
                    _conscriptsListVisibility = value;
            }
        }

        private string _conscriptCommandsListVisibility = "Hidden";

        public string ConscriptCommandsListVisibility
        {
            get
            {
                return _conscriptCommandsListVisibility;
            }

            set
            {
                if(_conscriptCommandsListVisibility != value)
                    _conscriptCommandsListVisibility = value;
            }
        }

        private string _progressBarVisibility = "Hidden";

        public string ProgressBarVisibility
        {
            get
            {
                return _progressBarVisibility;
            }

            set
            {
                if( _progressBarVisibility != value)
                    _progressBarVisibility = value;
            }
        }

        private string _progressBarLabelVisibility = "Hidden";

        public string ProgressBarLabelVisibility
        {
            get
            {
                return _progressBarLabelVisibility;
            }

            set
            {
                if(_progressBarLabelVisibility != value)
                    _progressBarLabelVisibility = value;
            }
        }

        private string _notFoundLabelVisibility = "Hidden";

        public string NotFoundLabelVisibility
        {
            get
            {
                return _notFoundLabelVisibility;
            }

            set
            {
                if(_notFoundLabelVisibility != value)
                    _notFoundLabelVisibility = value;
            }
        }

        private string _searchButtonEnable = "False";

        public string SearchButtonEnable
        {
            get
            {
                return _searchButtonEnable;
            }

            set
            {
                if (_searchButtonEnable != value)
                { 
                    _searchButtonEnable = value;
                }
            }
        }

        private string _conscriptCommandStation;

        public string ConscriptCommandStation
        {
            get
            {
                return _conscriptCommandStation;
            }

            set
            {
                if(_conscriptCommandStation != value)
                {
                    if (value != null)
                    {
                        ShowConscriptsCommandList();
                        HideConscriptsList();
                        ClearConscriptFields();
                    }
                    _conscriptCommandStation = value;
                }
            }
        }

        private string _conscriptCommandMilKind;

        public string ConscriptCommandMilKind
        {
            get
            {
                return _conscriptCommandMilKind;
            }

            set
            {
                if(_conscriptCommandMilKind != value)
                {
                    if (value != null)
                    {
                        ShowConscriptsCommandList();
                        HideConscriptsList();
                        ClearConscriptFields();
                    }
                    _conscriptCommandMilKind = value;
                }
            }
        }

        private string _conscriptCommandArmyUnitNumber;

        public string ConscriptCommandArmyUnitNumber
        {
            get
            {
                return _conscriptCommandArmyUnitNumber;
            }

            set
            {
                if(_conscriptCommandArmyUnitNumber != value)
                {
                    if(value != null)
                    {
                        HideConscriptsList();
                        ShowConscriptsCommandList();
                        ClearConscriptFields();
                    }
                    _conscriptCommandArmyUnitNumber = value;
                }
            }
        }

        private string _conscriptCommandConscription;

        public string ConscriptCommandConscription
        {
            get
            {
                return _conscriptCommandConscription;
            }

            set
            {
                if(_conscriptCommandConscription != value)
                {
                    if (value != null)
                    {
                        ShowConscriptsCommandList();
                        HideConscriptsList();
                        ClearConscriptFields();
                    }
                    _conscriptCommandConscription = value;
                }
            }
        }

        private int _searchCount;

        public int SearchCount
        {
            get
            {
                return _searchCount;
            }

            set
            {
                if(_searchCount != value)
                    _searchCount = value;
            }
        }

        private string _searchResultVisibility = "Hidden";

        public string SearchResultVisibility
        {
            get
            {
                return _searchResultVisibility;
            }

            set
            {
                if(_searchResultVisibility != value)
                    _searchResultVisibility = value;
            }
        }

        private string _conscriptPrintButtonVisibility = "Hidden";

        public string ConscriptPrintButtonVisibility
        {
            get
            {
                return _conscriptPrintButtonVisibility;
            }

            set
            {
                if(_conscriptPrintButtonVisibility != value)
                    _conscriptPrintButtonVisibility = value;
            }
        }

        private string _formingDocumentLabelVisibility = "Hidden";

        public string FormingDocumentLabelVisibility
        {
            get
            {
                return _formingDocumentLabelVisibility;
            }

            set
            {
                if(_formingDocumentLabelVisibility != value)
                {
                    _formingDocumentLabelVisibility = value;
                }
            }
        }

        public void HideConscriptsList()
        {
            ConscriptsListVisibility = "Hidden";
            OnPropertyChanged("ConscriptsListVisibility");
            ConscriptPrintButtonVisibility = "Hidden";
            OnPropertyChanged("ConscriptPrintButtonVisibility");
        }

        public void HideConscriptCommandsList()
        {
            ConscriptCommandsListVisibility = "Hidden";
            OnPropertyChanged("ConscriptCommandsListVisibility");
        }

        public void ShowConscriptsCommandList()
        {
            ConscriptCommandsListVisibility = "Visible";
            OnPropertyChanged("ConscriptCommandsListVisibility");
        }

        public void ShowConscriptsList()
        {
            ConscriptsListVisibility = "Visible";
            OnPropertyChanged("ConscriptsListVisibility");
        }

        public void ClearConscriptFields()
        {
            ConscriptLastName = null;
            OnPropertyChanged("ConscriptLastName");
            ConscriptFirstName = null;
            OnPropertyChanged("ConscriptFirstName");
            ConscriptMiddleName = null;
            OnPropertyChanged("ConscriptMiddleName");
            ConscriptBirthDate = null;
            OnPropertyChanged("ConscriptBirthDate");
            ConscriptPassportSeries = null;
            OnPropertyChanged("ConscriptPassportSeries");
            ConscriptPassportNumber = null;
            OnPropertyChanged("ConscriptPassportNumber");
            ConscriptMilitaryTicketSeries = null;
            OnPropertyChanged("ConscriptMilitaryTicketSeries");
            ConscriptMilitaryTicketNumber = null;
            OnPropertyChanged("ConscriptMilitaryTicketNumber");
            ConscriptRVK = null;
            OnPropertyChanged("ConscriptRVK");
            Conscript = null;
            OnPropertyChanged("Conscript");
        }

        public void ClearConscriptCommandFields()
        {
            ConscriptCommandArmyUnitNumber = null;
            OnPropertyChanged("ConscriptCommandArmyUnitNumber");
            ConscriptCommandStation = null;
            OnPropertyChanged("ConscriptCommandStation");
            ConscriptCommandMilKind = null;
            OnPropertyChanged("ConscriptCommandMilKind");
            ConscriptCommandConscription = null;
            OnPropertyChanged("ConscriptCommandConscription");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private RelayCommand _clearFieldsCommand;

        public RelayCommand ClearFieldsCommand
        {
            get
            {
                return _clearFieldsCommand ?? (_clearFieldsCommand = new RelayCommand(obj =>
                {
                    ClearConscriptFields();
                    ClearConscriptCommandFields();
                }));
            }
        }

        private RelayCommand _showConscriptCommand;

        public RelayCommand ShowConscriptCommand
        {
            get
            {
                return _showConscriptCommand ?? (_showConscriptCommand = new RelayCommand(obj =>
                {
                    if (obj == null) return;

                    ConscriptViewModel ViewModel = new ConscriptViewModel();
                    ConscriptView view = new ConscriptView(ViewModel, (Conscript)obj);

                    view.Owner = View;
                    view.ShowDialog();
                }));
            }
        }

        private RelayCommand _showConscriptCommandCommand;

        public RelayCommand ShowConscriptCommandCommand
        {
            get
            {
                return _showConscriptCommandCommand ?? (_showConscriptCommandCommand = new RelayCommand(obj =>
                {
                    if (obj == null) return;

                    ConscriptCommandViewModel ViewModel = new ConscriptCommandViewModel();
                    ConscriptCommandView view = new ConscriptCommandView(ViewModel, (ConscriptCommand)obj);

                    view.Owner = View;
                    view.ShowDialog();
                }));
            }
        }

        private RelayCommand _printConscriptsCommand;

        public RelayCommand PrintConscriptsCommand
        {
            get
            {
                return _printConscriptsCommand ?? (_printConscriptsCommand = new RelayCommand(async obj =>
                {
                    FormingDocumentLabelVisibility = "Visible";
                    OnPropertyChanged("FormingDocumentLabelVisibility");
                    ProgressBarVisibility = "Visible";
                    OnPropertyChanged("ProgressBarVisibility");

                    try
                    {
                        await FormDocument(PrintList);
                    }   
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при выводе на печать призывника\n{ex.Message}", "Ошибка", MessageBoxButton.OKCancel);
                    }
                    finally
                    {
                        FormingDocumentLabelVisibility = "Hidden";
                        OnPropertyChanged("FormingDocumentLabelVisibility");
                        ProgressBarVisibility = "Hidden";
                        OnPropertyChanged("ProgressBarVisibility");
                    }
                }));
            }
        }

        private RelayCommand _addConscriptToPrintList;

        public RelayCommand AddConscriptToPrintList
        {
            get
            {
                return _addConscriptToPrintList ?? (_addConscriptToPrintList = new RelayCommand(obj =>
                {
                    var SelectedItems = obj as IList;
                    try 
                    {
                        var SelectedConscripts = SelectedItems.Cast<Conscript>();

                        if (SelectedConscripts == null)
                        {
                            return;
                        }

                        foreach (var Conscript in SelectedConscripts)
                            PrintList.Add(Conscript);
                    } 
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при добавлении призывника в список печати\n{ex.Message}", "Ошибка", MessageBoxButton.OKCancel);
                    }
                    finally
                    {
                        MessageBox.Show("Призывник(и) успешно добавлен(ы) в список на печать!", "Информация", MessageBoxButton.OK);
                    }
                }));
            }
        }

        private RelayCommand _clearPrintList;

        public RelayCommand ClearPrintList
        {
            get
            {
                return _clearPrintList ?? (_clearPrintList = new RelayCommand(obj =>
                {
                    PrintList.Clear();
                    MessageBox.Show("Список на печать успешно очищен!", "Информация", MessageBoxButton.OK);
                }));
            }
        }

        private RelayCommand _searchCommand;

        public RelayCommand SearchCommand
        {
            get
            {
                return _searchCommand ?? (_searchCommand = new RelayCommand(async obj =>
                {
                    if (SearchButtonEnable != "True") return;

                    if ((ConscriptLastName == null || ConscriptLastName == "") && (ConscriptFirstName == null || ConscriptFirstName == "") &&
                    (ConscriptMiddleName == null || ConscriptMiddleName == "") && (ConscriptBirthDate == null) && (ConscriptRVK == null || ConscriptRVK == "") &&
                    (ConscriptCommandConscription == null || ConscriptCommandConscription == "") && (ConscriptPassportSeries == null || ConscriptPassportSeries == "") 
                    && (ConscriptPassportNumber == null || ConscriptPassportNumber == "") && (ConscriptMilitaryTicketSeries == null || ConscriptMilitaryTicketSeries == "") 
                    && (ConscriptMilitaryTicketNumber == null || ConscriptMilitaryTicketNumber == "") && (ConscriptCommandStation == null || ConscriptCommandStation == "") 
                    && (ConscriptCommandMilKind == null || ConscriptCommandMilKind == "") && (ConscriptCommandArmyUnitNumber == null || ConscriptCommandArmyUnitNumber == "")
                    && (Conscript == null || Conscript == ""))
                    {
                        MessageBox.Show("Не заполнены поля для поиска призывника/команды", "Ошибка", MessageBoxButton.OK);
                        return;
                    }

                    ConscriptsList.Clear();
                    ConscriptCommandsList.Clear();

                    SearchResultVisibility = "Hidden";
                    OnPropertyChanged("SearchResultVisibility");
                    ProgressBarVisibility = "Visible";
                    OnPropertyChanged("ProgressBarVisibility");
                    ProgressBarLabelVisibility = "Visible";
                    OnPropertyChanged("ProgressBarLabelVisibility");
                    SearchButtonEnable = "False";
                    OnPropertyChanged("SearchButtonEnable");
                    NotFoundLabelVisibility = "Hidden";
                    OnPropertyChanged("NotFoundLabelVisibility");
                    ConscriptPrintButtonVisibility = "Hidden";
                    OnPropertyChanged("ConscriptPrintButtonVisibility");

                    if (ConscriptLastName != null && ConscriptLastName != "") QueryHelper.ConscriptQueryParameters["Key1"] = ConscriptLastName;
                    if (ConscriptFirstName != null && ConscriptFirstName != "") QueryHelper.ConscriptQueryParameters["Key2"] = ConscriptFirstName;
                    if (ConscriptMiddleName != null && ConscriptMiddleName != "") QueryHelper.ConscriptQueryParameters["Key3"] = ConscriptMiddleName;
                    if (ConscriptBirthDate != null) QueryHelper.ConscriptQueryParameters["Key4"] = ConscriptBirthDate.Value.ToShortDateString();
                    if (ConscriptRVK != null) QueryHelper.ConscriptQueryParameters["Key5"] = ConscriptRVK;
                    if (ConscriptPassportSeries != null && ConscriptPassportSeries != "") QueryHelper.ConscriptQueryParameters["Key6"] = ConscriptPassportSeries;
                    if (ConscriptPassportNumber != null && ConscriptPassportNumber != "") QueryHelper.ConscriptQueryParameters["Key7"] = ConscriptPassportNumber;
                    if (ConscriptMilitaryTicketSeries != null && ConscriptMilitaryTicketSeries != "") QueryHelper.ConscriptQueryParameters["Key8"] = ConscriptMilitaryTicketSeries;
                    if (ConscriptMilitaryTicketNumber != null && ConscriptMilitaryTicketNumber != "") QueryHelper.ConscriptQueryParameters["Key9"] = ConscriptMilitaryTicketNumber;
                    if (Conscript != null && Conscript != "") QueryHelper.ConscriptQueryParameters["Key10"] = Config.ConscriptList[Conscript];

                    if (ConscriptCommandStation != null && ConscriptCommandStation != "") QueryHelper.ConscriptCommandQueryParameters["Key11"] = ConscriptCommandStation;
                    if (ConscriptCommandMilKind != null && ConscriptCommandMilKind != "") QueryHelper.ConscriptCommandQueryParameters["Key12"] = ConscriptCommandMilKind;
                    if (ConscriptCommandArmyUnitNumber != null && ConscriptCommandArmyUnitNumber != "") QueryHelper.ConscriptCommandQueryParameters["Key13"] = ConscriptCommandArmyUnitNumber;
                    if (ConscriptCommandConscription != null && ConscriptCommandConscription != "") QueryHelper.ConscriptCommandQueryParameters["Key14"] = Config.ConscriptList[ConscriptCommandConscription];

                    QueryHelper.FormQuery();

                    await DBWorker.ExecuteQuery();

                    List<object> RecievedData = DBWorker.RecievedData;

                    if(DBWorker.IsConscriptQuery)
                    {
                        foreach (Conscript el in RecievedData)
                            ConscriptsList.Add(el);
                        SearchCount = ConscriptsList.Count;

                        ConscriptPrintButtonVisibility = "Visible";
                        OnPropertyChanged("ConscriptPrintButtonVisibility");
                    }
                    else
                    {
                        foreach (ConscriptCommand el in RecievedData)
                            ConscriptCommandsList.Add(el);
                        SearchCount = ConscriptCommandsList.Count;

                        ConscriptPrintButtonVisibility = "Hidden";
                        OnPropertyChanged("ConscriptPrintButtonVisibility");
                    }

                    SearchResultVisibility = "Visible";
                    OnPropertyChanged("SearchCount");
                    OnPropertyChanged("SearchResultVisibility");

                    QueryHelper.ClearQuery();

                    if (ConscriptsList.Count == 0 && ConscriptCommandsList.Count == 0)
                    {
                        NotFoundLabelVisibility = "Visible";
                        OnPropertyChanged("NotFoundLabelVisibility");
                    }

                    ProgressBarVisibility = "Hidden";
                    OnPropertyChanged("ProgressBarVisibility");
                    ProgressBarLabelVisibility = "Hidden";
                    OnPropertyChanged("ProgressBarLabelVisibility");
                    SearchButtonEnable = "True";
                    OnPropertyChanged("SearchButtonEnable");
                }));
            }
        }

        public void ShowResultExcel(string PathToFile)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb = excel.Workbooks.Open(PathToFile);

            excel.ScreenUpdating = true;
            excel.Visible = true;
        }

        public async Task FormDocument(IEnumerable<Conscript> SelectedConscripts)
        {

            await Task.Run(() =>
            {
                XLWorkbook inputWb = new XLWorkbook("ConscriptCard.xlsx");
                XLWorkbook outputWb = new XLWorkbook();
                IXLWorksheet inputSheet = inputWb.Worksheet(1);

                inputSheet.CopyTo(outputWb, "Result");

                IXLWorksheet outputSheet = outputWb.Worksheet(1);
                string ResultFileName = "Найденные призывники.xlsx";
                string FullResultFileName = "";

                int i = 2;

                foreach (var Conscript in SelectedConscripts)
                {
                    outputSheet.Cell(i, 1).SetValue(Conscript.LastName);
                    outputSheet.Cell(i, 2).SetValue(Conscript.FirstName);
                    outputSheet.Cell(i, 3).SetValue(Conscript.MiddleName);
                    outputSheet.Cell(i, 4).SetValue(Conscript.BirthDate);
                    outputSheet.Cell(i, 5).SetValue(Conscript.RVK);
                    outputSheet.Cell(i, 6).SetValue(Conscript.ArrivalDate);
                    outputSheet.Cell(i, 7).SetValue($"{Conscript.PassportSeries} {Conscript.PassportNumber}{(Conscript.PassportDate == null ? "" : $"{Environment.NewLine}Выдан{Environment.NewLine}{Conscript.PassportDate}")}{(Conscript.PassportGiven == null ? "" : $"{Environment.NewLine}{Conscript.PassportGiven}")}");
                    outputSheet.Cell(i, 8).SetValue($"{Conscript.MilitaryTicketSeries} {Conscript.MilitaryTicketNumber}");
                    outputSheet.Cell(i, 9).SetValue($"{Conscript.LNSeries} {Conscript.LNNumber}");
                    outputSheet.Cell(i, 10).SetValue($"{Conscript.MilKind}{Environment.NewLine}{Conscript.Station}{Environment.NewLine}в/ч {Conscript.ArmyUnitNumber}{Environment.NewLine}{Conscript.DepartureDate}");
                    outputSheet.Cell(i, 11).SetValue(Conscript.NPr != 0 ? $"№ {Conscript.NPr} от {Conscript.DPr}" : "");
                    outputSheet.Cell(i, 12).SetValue(Conscript.Nvesh != null && Conscript.Nvesh != "" ? $"№ {Conscript.Nvesh} от {Conscript.Dvesh}" : "");
                    outputSheet.Cell(i, 13).SetValue(Conscript.Conscription);

                    outputSheet.Cells($"A{i}:M{i}").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    outputSheet.Cells($"A{i}:M{i}").Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                    i++;
                }

                outputSheet.Rows().AdjustToContents();

                FullResultFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), ResultFileName);

                outputWb.SaveAs(FullResultFileName);
                ShowResultExcel(FullResultFileName);
            });
        }

        public string this[string columnName]
        { 
            get
            {
                string Error = String.Empty;
                char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

                switch(columnName)
                {
                    case "ConscriptLastName":
                        if (!String.IsNullOrWhiteSpace(ConscriptLastName))
                        { 
                            if(!System.Text.RegularExpressions.Regex.IsMatch(ConscriptLastName, @"^[а-яА-Я\-ёЁ]+$"))
                            {
                                Error = "Фамилия должна состоять только из букв";
                                SearchButtonEnable = "False";
                                OnPropertyChanged("SearchButtonEnable");
                                break;
                            }
                            else
                            {
                                SearchButtonEnable = "True";
                                OnPropertyChanged("SearchButtonEnable");
                            }
                        }
                        OnPropertyChanged("SearchButtonEnable");
                        break;
                    case "ConscriptFirstName":
                        if(!String.IsNullOrWhiteSpace(ConscriptFirstName))
                        {
                            if (!System.Text.RegularExpressions.Regex.IsMatch(ConscriptFirstName, @"^[а-яА-Я\-ёЁ]+$"))
                            {
                                Error = "Имя должно состоять только из букв";
                                SearchButtonEnable = "False";
                                OnPropertyChanged("SearchButtonEnable");
                                break;
                            }
                            else
                            {
                                SearchButtonEnable = "True";
                                OnPropertyChanged("SearchButtonEnable");
                            }
                        }
                        OnPropertyChanged("SearchButtonEnable");
                        break;
                    case "ConscriptMiddleName":
                        if (!String.IsNullOrWhiteSpace(ConscriptMiddleName))
                        { 
                            if(!System.Text.RegularExpressions.Regex.IsMatch(ConscriptMiddleName, @"^[а-яА-Я\-ёЁ]+$"))
                            {
                                Error = "Отчество должно состоять только из букв";
                                SearchButtonEnable = "False";
                                OnPropertyChanged("SearchButtonEnable");
                                break;
                            }
                            else
                            {
                                SearchButtonEnable = "True";
                                OnPropertyChanged("SearchButtonEnable");
                            }
                        }
                        OnPropertyChanged("SearchButtonEnable");
                        break;
                    case "ConscriptCommandArmyUnitNumber":
                        if (!String.IsNullOrWhiteSpace(ConscriptCommandArmyUnitNumber))
                        {
                            if (ConscriptCommandArmyUnitNumber.Length > 10)
                            {
                                Error = "Номер воинской части может содержать только 10 символов";
                                SearchButtonEnable = "False";
                                OnPropertyChanged("SearchButtonEnable");
                                break;
                            }
                            else
                            {
                                SearchButtonEnable = "True";
                                OnPropertyChanged("SearchButtonEnable");
                            }
                        }
                    break;
                    case "ConscriptPassportSeries":
                        if (!String.IsNullOrWhiteSpace(ConscriptPassportSeries))
                        {
                            if (!System.Text.RegularExpressions.Regex.IsMatch(ConscriptPassportSeries, @"^[0-9]{4}$"))
                            {
                                Error = "Серия паспорта должна состоять из 4 цифр";
                                SearchButtonEnable = "False";
                                OnPropertyChanged("SearchButtonEnable");
                                break;
                            }
                            else
                            {
                                SearchButtonEnable = "True";
                                OnPropertyChanged("SearchButtonEnable");
                            }
                        }
                        OnPropertyChanged("SearchButtonEnable");
                        break;
                    case "ConscriptPassportNumber":
                        if (!String.IsNullOrWhiteSpace(ConscriptPassportNumber))
                        { 
                            if(!System.Text.RegularExpressions.Regex.IsMatch(ConscriptPassportNumber, @"^[0-9]{6}$"))
                            {
                                Error = "Номер паспорта должен состоять из 6 цифр";
                                SearchButtonEnable= "False";
                                OnPropertyChanged("SearchButtonEnable");
                                break;
                            } 
                            else
                            {
                                SearchButtonEnable = "True";
                                OnPropertyChanged("SearchButtonEnable");
                            }
                        }
                        OnPropertyChanged("SearchButtonEnable");
                        break;
                    case "ConscriptMilitaryTicketSeries":
                        if(!String.IsNullOrWhiteSpace(ConscriptMilitaryTicketSeries)) 
                        {
                            if(!System.Text.RegularExpressions.Regex.IsMatch(ConscriptMilitaryTicketSeries, @"^[А-Я]{2}$"))
                            {
                                Error = "Серия военного билета должна содержать две заглавные буквы";
                                SearchButtonEnable= "False";
                                OnPropertyChanged("SearchButtonEnable");
                                break;
                            }
                            else
                            {
                                SearchButtonEnable = "True";
                                OnPropertyChanged("SearchButtonEnable");
                            }
                        }
                        OnPropertyChanged("SearchButtonEnable");
                        break;
                    case "ConscriptMilitaryTicketNumber":
                    {
                        if (!String.IsNullOrWhiteSpace(ConscriptMilitaryTicketNumber))
                        {
                            if (!System.Text.RegularExpressions.Regex.IsMatch(ConscriptMilitaryTicketNumber, @"^[0-9]{7}$"))
                            {
                                Error = "Номер военного билета должен содержать 7 цифр";
                                SearchButtonEnable = "False";
                                OnPropertyChanged("SearchButtonEnable");
                                break;
                            }
                            else
                            {
                                SearchButtonEnable = "True";
                                OnPropertyChanged("SearchButtonEnable");
                            }
                        }
                        break;
                    }
                }
                return Error;
            }
        }

        public string Error
        {
            get { throw new NotImplementedException();  }
        }
    }
}
