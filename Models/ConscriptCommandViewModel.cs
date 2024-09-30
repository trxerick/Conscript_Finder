using ConscriptFinder.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ConscriptFinder.States;
using ConscriptFinder.Logic;
using System.Collections.ObjectModel;
using ClosedXML.Excel;
using System.IO;

namespace ConscriptFinder.Models
{
    public class ConscriptCommandViewModel : INotifyPropertyChanged
    {
        public ConscriptCommandView View;

        private ConscriptCommand _conscriptCommand;
        public ConscriptCommand ConscriptCommand
        {
            get
            {
                return _conscriptCommand;
            }

            set
            {
                if (_conscriptCommand != value)
                    _conscriptCommand = value;
            }
        }

        private string _conscriptCommandOSPNumber;

        public string ConscriptCommandOSPNumber
        {
            get
            {
                return ConscriptCommand.OSPNumber;
            }

            set
            {
                if(_conscriptCommandOSPNumber != value)
                    _conscriptCommandOSPNumber = value;
            }
        }

        private string _conscriptCommandStation;

        public string ConscriptCommandStation
        {
            get
            {
                return ConscriptCommand.Station;
            }

            set
            {
                if (_conscriptCommandStation != value)
                    _conscriptCommandStation = value;
            }
        }

        private string _conscriptCommandEcheloneNumber;

        public string ConscriptCommandEcheloneNumber
        {
            get
            {
                return ConscriptCommand.EcheloneNumber;
            }

            set
            {
                if (_conscriptCommandEcheloneNumber != value)
                    _conscriptCommandEcheloneNumber = value;
            }
        }

        private string _conscriptCommandMilKind;

        public string ConscriptCommandMilKind
        {
            get
            {
                return ConscriptCommand.MilKind;
            }

            set
            {
                if (_conscriptCommandMilKind != value)
                    _conscriptCommandMilKind = value;
            }
        }

        private string _conscriptCommandArmyUnitNumber;

        public string ConscriptCommandArmyUnitNumber
        {
            get
            {
                return ConscriptCommand.ArmyUnitNumber;
            }

            set
            {
                if (_conscriptCommandArmyUnitNumber != value)
                    _conscriptCommandArmyUnitNumber = value;
            }
        }

        private string _conscriptCommandDepartureDate;

        public string ConscriptCommandDepartureDate
        {
            get
            {
                return ConscriptCommand.DepartureDate;
            }

            set
            {
                if (_conscriptCommandDepartureDate != value)
                    _conscriptCommandDepartureDate = value;
            }
        }

        private string _conscriptCommandRezh;

        public string ConscriptCommandRezh
        {
            get
            {
                return ConscriptCommand.Rezh;
            }

            set
            {
                if (_conscriptCommandRezh != value)
                    _conscriptCommandRezh = value;
            }
        }

        private string _conscriptCommandConscription;

        public string ConscriptCommandConscription
        {
            get
            {
                return ConscriptCommand.Conscription;
            }

            set
            {
                if (_conscriptCommandConscription != value)
                    _conscriptCommandConscription = value;
            }
        }

        private string _conscriptCommandPredsRank;

        public string ConscriptCommandPredsRank
        {
            get
            {
                return ConscriptCommand.PredsRank;
            }

            set
            {
                if (_conscriptCommandPredsRank != value)
                    _conscriptCommandPredsRank = value;
            }
        }

        private string _conscriptCommandPreds;

        public string ConscriptCommandPreds
        {
            get
            {
                return ConscriptCommand.Preds;
            }

            set
            {
                if (_conscriptCommandPreds != value)
                    _conscriptCommandPreds = value;
            }
        }

        private string _conscriptCommandPredsDocSeries;

        public string ConscriptCommandPredsDocSeries
        {
            get
            {
                return ConscriptCommand.PredsDocSeries;
            }

            set
            {
                if (_conscriptCommandPredsDocSeries != value)
                    _conscriptCommandPredsDocSeries = value;
            }
        }

        private string _conscriptCommandPredsDocNumber;

        public string ConscriptCommandPredsDocNumber
        {
            get
            {
                return ConscriptCommand.PredsDocNum;
            }

            set
            {
                if (_conscriptCommandPredsDocNumber != value)
                    _conscriptCommandPredsDocNumber = value;
            }
        }

        private string _conscriptCommandPredsDocGiven;

        public string ConscriptCommandPredsDocGiven
        {
            get
            {
                return ConscriptCommand.PredsDocGiven;
            }

            set
            {
                if (_conscriptCommandPredsDocGiven != value)
                    _conscriptCommandPredsDocGiven = value;
            }
        }

        private string _conscriptCommandPredsDocDate;

        public string ConscriptCommandPredsDocDate
        {
            get
            {
                return ConscriptCommand.PredsDocDate;
            }

            set
            {
                if (_conscriptCommandPredsDocDate != value)
                    _conscriptCommandPredsDocDate = value;
            }
        }

        private string _conscriptCommandPredsSpec;

        public string ConscriptCommandPredsSpec
        {
            get
            {
                return ConscriptCommand.PredsSpec;
            }

            set
            {
                if (_conscriptCommandPredsSpec != value)
                    _conscriptCommandPredsSpec = value;
            }
        }

        private string _conscriptCommandZIP;

        public string ConscriptCommandZIP
        {
            get
            {
                return ConscriptCommand.ZIP;
            }

            set
            {
                if (_conscriptCommandZIP != value)
                    _conscriptCommandZIP = value;
            }
        }

        private string _conscriptCommandCity;

        public string ConscriptCommandCity
        {
            get
            {
                return ConscriptCommand.City;
            }

            set
            {
                if (_conscriptCommandCity != value)
                    _conscriptCommandCity = value;
            }
        }

        private string _conscriptCommandStreet;

        public string ConscriptCommandStreet
        {
            get
            {
                return ConscriptCommand.Street;
            }

            set
            {
                if (ConscriptCommandStreet != value)
                    ConscriptCommandStreet = value;
            }
        }

        private string _conscriptCommandPhoneNumber;

        public string ConscriptCommandPhoneNumber
        {
            get
            {
                return ConscriptCommand.PhoneNumber;
            }

            set
            {
                if (_conscriptCommandPhoneNumber != value)
                    _conscriptCommandPhoneNumber = value;
            }
        }

        private string _conscriptCommandOkrug;

        public string ConscriptCommandOkrug
        {
            get
            {
                return ConscriptCommand.Okrug;
            }

            set
            {
                if(_conscriptCommandOkrug != value)
                    _conscriptCommandOkrug = value;
            }
        }

        private string _conscriptCommandRyad;

        public string ConscriptCommandRyad
        {
            get
            {
                return $"Приказ № {ConscriptCommand.NPr} от {ConscriptCommand.DPr}";
            }

            set
            {
                if(_conscriptCommandRyad != value)
                    _conscriptCommandRyad = value;
            }
        }

        private string _conscriptCommandVesh;

        public string ConscriptCommandVesh
        {
            get
            {
                return $"Аттестат № {ConscriptCommand.Nvesh} от {ConscriptCommand.Dvesh}";
            }

            set
            {
                if(_conscriptCommandVesh != value)
                    _conscriptCommandVesh = value;
            }
        }

        private string _searchingStatusVisibility = "Hidden";

        public string SearchingStatusVisibility
        {
            get
            {
                return _searchingStatusVisibility;
            }

            set
            {
                if(_searchingStatusVisibility != value)
                    _searchingStatusVisibility = value;
            }
        }

        private string _exportStatusVisibility = "Hidden";

        public string ExportStatusVisibility
        {
            get
            {
                return _exportStatusVisibility;
            }

            set
            {
                if (_exportStatusVisibility != value)
                    _exportStatusVisibility = value;
            }
        }

        private string _searchButtonVisibility = "Visible";

        public string SearchButtonVisibility
        {
            get
            {
                return _searchButtonVisibility;
            }

            set
            {
                if (_searchButtonVisibility != value)
                    _searchButtonVisibility = value;
            }
        }

        private string _conscriptListVisibility = "Hidden";

        public string ConscriptListVisibility
        {
            get
            {
                return _conscriptListVisibility;
            }

            set
            {
                if (_conscriptListVisibility != value)
                    _conscriptListVisibility = value;
            }
        }

        private string _exportVisibility = "Hidden";

        public string ExportVisibility
        {
            get
            {
                return _exportVisibility;
            }

            set
            {
                if (_exportVisibility != value)
                    _exportVisibility = value;
            }
        }

        private RelayCommand _exportCommand;

        public RelayCommand ExportCommand
        {
            get
            {
                return _exportCommand ?? (_exportCommand = new RelayCommand(async obj =>
                {
                    SearchingStatusVisibility = "Visible";
                    OnPropertyChanged("SearchingStatusVisibility");
                    await FormDocument();
                    SearchingStatusVisibility = "Hidden";
                    OnPropertyChanged("SearchingStatusVisibility");
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

        public async Task FormDocument()
        {
            await Task.Run(() =>
            {
                XLWorkbook inputWb = new XLWorkbook("ConscriptCommandCard.xlsx");
                XLWorkbook outputWb = new XLWorkbook();
                IXLWorksheet inputSheet = inputWb.Worksheet(1);

                inputSheet.CopyTo(outputWb, "Result");

                IXLWorksheet outputSheet = outputWb.Worksheet(1);
                string ResultFileName = $"Выгрузка {ConscriptCommand.MilKind} вч {ConscriptCommand.ArmyUnitNumber} за {ConscriptCommand.Conscription}.xlsx";
                string FullResultFileName = "";

                int i = 2;

                foreach (var Conscript in ConscriptList)
                {
                    outputSheet.Cell(i, 1).SetValue(Conscript.LastName);
                    outputSheet.Cell(i, 2).SetValue(Conscript.FirstName);
                    outputSheet.Cell(i, 3).SetValue(Conscript.MiddleName);
                    outputSheet.Cell(i, 4).SetValue(Conscript.BirthDate);
                    outputSheet.Cell(i, 5).SetValue(Conscript.PlaceOfBirth);
                    outputSheet.Cell(i, 6).SetValue($"{Conscript.MilitaryTicketSeries} {Conscript.MilitaryTicketNumber}");
                    outputSheet.Cell(i, 7).SetValue($"{Conscript.PassportSeries} {Conscript.PassportNumber}{(Conscript.PassportDate == null ? "" : $"{Environment.NewLine}Выдан{Environment.NewLine}{Conscript.PassportDate}")}{(Conscript.PassportGiven == null ? "" : $"{Environment.NewLine}{Conscript.PassportGiven}")}");
                    outputSheet.Cell(i, 8).SetValue($"{Conscript.LNSeries} {Conscript.LNNumber}");
                    outputSheet.Cell(i, 9).SetValue(Conscript.Education);
                    outputSheet.Cell(i, 10).SetValue(Conscript.FamilyStatus);
                    outputSheet.Cell(i, 11).SetValue(Conscript.Speciality);
                    outputSheet.Cell(i, 12).SetValue(Conscript.RVK);
                    outputSheet.Cell(i, 13).SetValue(Conscript.AccessForm != 0 && Conscript.AccessFormNumber != "" ? $"Ф-{Conscript.AccessForm} № {Conscript.AccessFormNumber}{Environment.NewLine} от {Conscript.AccessFormDate}" : "");
                    outputSheet.Cell(i, 14).SetValue($"{Conscript.DriverLicenseSeries} {Conscript.DriverLicenseNumber} {Environment.NewLine}{Conscript.DriverLicenseDate}");
                    outputSheet.Cell(i, 15).SetValue(Conscript.NPU);
                    outputSheet.Cell(i, 16).SetValue(Conscript.OPS);
                    outputSheet.Cell(i, 17).SetValue(Conscript.GODN + Conscript.PREDN);
                    outputSheet.Cell(i, 18).SetValue(Conscript.ArrivalDate);
                    outputSheet.Cell(i, 19).SetValue($"{Conscript.MilKind}{Environment.NewLine}{Conscript.Station}{Environment.NewLine}в/ч {Conscript.ArmyUnitNumber}{Environment.NewLine}{Conscript.DepartureDate}");
                    outputSheet.Cell(i, 20).SetValue(Conscript.NPr != 0 ? $"№ {Conscript.NPr} от {Conscript.DPr}" : "");
                    outputSheet.Cell(i, 21).SetValue(Conscript.Nvesh != null && Conscript.Nvesh != "" ? $"№ {Conscript.Nvesh} от {Conscript.Dvesh}" : "");
                    outputSheet.Cell(i, 22).SetValue(Conscript.Conscription);

                    outputSheet.Cells($"A{i}:V{i}").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    outputSheet.Cells($"A{i}:V{i}").Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                    i++;
                }

                outputSheet.Rows().AdjustToContents();

                FullResultFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), ResultFileName);

                outputWb.SaveAs(FullResultFileName);
                ShowResultExcel(FullResultFileName);
            });
        }

        private ObservableCollection<Conscript> _conscriptsList = new ObservableCollection<Conscript>();

        public ObservableCollection<Conscript> ConscriptList
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

        private RelayCommand _loadConscriptsList;

        public RelayCommand LoadConscriptsList
        { 
            get
            {
                return _loadConscriptsList ?? (_loadConscriptsList = new RelayCommand(async obj =>
                {
                    SearchButtonVisibility = "Hidden";
                    OnPropertyChanged("SearchButtonVisibility");
                    SearchingStatusVisibility = "Visible";
                    OnPropertyChanged("SearchingStatusVisibility");

                    DBWorker.Query = QueryHelper.ConscriptQuery + $" WHERE *что-то* = \'{Config.ConscriptList[ConscriptCommand.Conscription]}\' AND *что-то* = \'{ConscriptCommand.OSPNumber}\'";
                    await DBWorker.ExecuteQuery();

                    SearchingStatusVisibility = "Hidden";
                    OnPropertyChanged("SearchingStatusVisibility");

                    List<object> RecievedData = DBWorker.RecievedData;

                    foreach (Conscript el in RecievedData)
                        ConscriptList.Add(el);

                    ConscriptListVisibility = "Visible";
                    OnPropertyChanged("ConscriptListVisibility");
                    ExportVisibility = "Visible";
                    OnPropertyChanged("ExportVisibility");
                }));
            }
        }

        private RelayCommand _closeViewCommand;

        public RelayCommand CloseViewCommand
        {
            get
            {
                return _closeViewCommand ?? (_closeViewCommand = new RelayCommand(obj =>
                {
                    ConscriptList.Clear();
                    View.Close();
                }));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
