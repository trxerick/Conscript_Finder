using ConscriptFinder.Logic;
using ConscriptFinder.States;
using ConscriptFinder.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConscriptFinder.Models
{
    public class ConscriptViewModel : INotifyPropertyChanged
    {
        public ConscriptView ConView;

        private Conscript _conscript;
        public Conscript Conscript
        {
            get
            {
                return _conscript;
            }

            set
            {
                if(_conscript != value)
                    _conscript = value;
            }
        }

        private string _conscriptFullName;

        public string ConscriptFullName
        {
            get
            {
                return Conscript.LastName + " " + Conscript.FirstName + " " + Conscript.MiddleName;
            }

            set
            {
                if(_conscriptFullName != value)
                    _conscriptFullName = value;
            }
        }

        private string _conscriptBirthDate;
        public string ConscriptBirthDate
        {
            get
            {
                return Conscript.BirthDate;
            }

            set
            {
                if(_conscriptBirthDate != value)
                    _conscriptBirthDate = value;
            }
        }

        private string _conscriptEducation;

        public string ConscriptEducation
        {
            get
            {
                return Conscript.Education;
            }

            set
            {
                if (_conscriptEducation != value)
                    _conscriptEducation = value;
            }
        }

        private string _conscriptSpeciality;

        public string ConscriptSpeciality
        {
            get
            {
                return Conscript.Speciality;
            }

            set
            {
                if (_conscriptSpeciality != value)
                    _conscriptSpeciality = value;
            }
        }

        private string _conscriptFamilyStatus;

        public string ConscriptFamilyStatus
        {
            get
            {
                return Conscript.FamilyStatus;
            }

            set
            {
                if (_conscriptFamilyStatus != value)
                    _conscriptFamilyStatus = value;
            }
        }

        private string _conscriptRVK;
        public string ConscriptRVK
        {
            get
            {
                return Conscript.RVK;
            }

            set
            {
                if (_conscriptRVK != value)
                    _conscriptRVK = value;
            }
        }

        private string _conscription;
        public string Conscription
        {
            get
            {
                return Conscript.Conscription;
            }

            set
            {
                if (_conscription != value)
                    _conscription = value;
            }
        }

        private string _conscriptPassportSeries;
        public string ConscriptPassportSeries
        {
            get
            {
                return Conscript.PassportSeries;
            }

            set
            {
                if (_conscriptPassportSeries != value)
                    _conscriptPassportSeries = value;
            }
        }

        private string _conscriptPassportNumber;

        public string ConscriptPassportNumber
        {
            get
            {
                return Conscript.PassportNumber;
            }

            set
            {
                if(_conscriptPassportNumber != value)
                    _conscriptPassportNumber = value;
            }
        }

        private string _conscriptPassportDate;

        public string ConscriptPassportDate
        {
            get
            {
                return Conscript.PassportDate;
            }

            set
            {
                if(_conscriptPassportDate != value)
                    _conscriptPassportDate = value;
            }
        }

        private string _conscriptPassportGiven;

        public string ConscriptPassportGiven
        {
            get
            {
                return Conscript.PassportGiven;
            }

            set
            {
                if(_conscriptPassportGiven != value)
                    _conscriptPassportGiven = value;
            }
        }

        private string _conscriptHealthCategory;

        public string ConscriptHealthCategory
        {
            get
            {
                return Conscript.GODN + Conscript.PREDN;
            }

            set
            {
                if (_conscriptHealthCategory != value)
                    _conscriptHealthCategory = value;
            }
        }

        private int _conscriptHeight;

        public int ConscriptHeight
        {
            get
            {
                return Conscript.Height;
            }

            set
            {
                if (_conscriptHeight != value)
                    _conscriptHeight = value;
            }
        }

        private int _conscriptWeight;

        public int ConscriptWeight
        {
            get
            {
                return Conscript.Weight;
            }

            set
            {
                if (_conscriptWeight != value)
                    _conscriptWeight = value;
            }
        }

        private string _conscriptEye;

        public string ConscriptEye
        {
            get
            {
                return Conscript.Eye;
            }

            set
            {
                if (_conscriptEye != value)
                    _conscriptEye = value;
            }
        }

        private string _conscriptTDT;

        public string ConscriptTDT
        {
            get 
            {
                return Conscript.TDT;
            }

            set
            {
                if (_conscriptTDT != value)
                    _conscriptTDT = value;
            }
        }

        private string _conscriptMilitaryTicketSeries;

        public string ConscriptMilitaryTicketSeries
        {
            get
            {
                return Conscript.MilitaryTicketSeries;
            }

            set
            {
                if (_conscriptMilitaryTicketSeries != value)
                    _conscriptMilitaryTicketSeries = value;
            }
        }

        private string _conscriptMilitaryTicketNumber;

        public string ConscriptMilitaryTicketNumber
        {
            get
            {
                return Conscript.MilitaryTicketNumber;
            }

            set
            {
                if (_conscriptMilitaryTicketNumber != value)
                    _conscriptMilitaryTicketNumber = value;
            }
        }

        private string _conscriptLNSeries;

        public string ConscriptLNSeries
        {
            get
            {
                return Conscript.LNSeries;
            }

            set
            {
                if (_conscriptLNSeries != value)
                    _conscriptLNSeries = value;
            }
        }

        private string _conscriptLNNumber;

        public string ConscriptLNNumber
        {
            get
            {
                return Conscript.LNNumber;
            }

            set
            {
                if (_conscriptLNNumber != value)
                    _conscriptLNNumber = value;
            }
        }

        private string _conscriptDriverLicenseSeries;

        public string ConscriptDriverLicenseSeries
        {
            get
            {
                return Conscript.DriverLicenseSeries;
            }

            set
            {
                if (_conscriptDriverLicenseSeries != value)
                    _conscriptDriverLicenseSeries = value;
            }
        }

        private string _conscriptDriverLicenseNumber;

        public string ConscriptDriverLicenseNumber
        {
            get
            {
                return Conscript.DriverLicenseNumber;
            }

            set
            {
                if (_conscriptDriverLicenseNumber != value)
                    _conscriptDriverLicenseNumber = value;
            }
        }

        private string _conscriptDriverLicenseDate;

        public string ConscriptDriverLicenseDate
        {
            get
            {
                return Conscript.DriverLicenseDate;
            }

            set
            {
                if (_conscriptDriverLicenseDate != value)
                    _conscriptDriverLicenseDate = value;
            }
        }

        private string _conscriptNPU;

        public string ConscriptNPU
        {
            get
            {
                return Conscript.NPU;
            }

            set
            {
                if (_conscriptNPU != value)
                    _conscriptNPU = value;
            }
        }

        private string _conscriptProfSuitability;

        public string ConscriptProfSuitability
        {
            get
            {
                return Conscript.ProfSuitability;
            }

            set
            {
                if (_conscriptProfSuitability != value)
                    _conscriptProfSuitability = value;
            }
        }

        private string _conscriptPlaceOfBirth;

        public string ConscriptPlaceOfBirth
        {
            get
            {
                return Conscript.PlaceOfBirth;
            }

            set
            {
                if (_conscriptPlaceOfBirth != value)
                    _conscriptPlaceOfBirth = value;
            }
        }

        private string _conscriptCommandMilKind;

        public string ConscriptCommandMilKind
        {
            get
            {
                return Conscript.MilKind;
            }

            set
            {
                if (_conscriptCommandMilKind != value)
                    _conscriptCommandMilKind = value;
            }
        }

        private string _conscriptCommandStation;

        public string ConscriptCommandStation
        {
            get
            {
                return Conscript.Station;
            }

            set
            {
                if (_conscriptCommandStation != value)
                    _conscriptCommandStation = value;
            }
        }

        private string _conscriptCommandArmyUnitNumber;

        public string ConscriptCommandArmyUnitNumber
        {
            get
            {
                return Conscript.ArmyUnitNumber;
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
                return Conscript.DepartureDate;
            }

            set
            {
                if (_conscriptCommandDepartureDate != value)
                    _conscriptCommandDepartureDate = value;
            }
        }

        private int _conscriptAccessForm;

        public int ConscriptAccessForm
        {
            get
            {
                return Conscript.AccessForm;
            }

            set
            {
                if (_conscriptAccessForm != value)
                    _conscriptAccessForm = value;
            }
        }
        private string _conscriptAccessNumber;

        public string ConscriptAccessNumber
        {
            get
            {
                return Conscript.AccessFormNumber;
            }

            set
            {
                if (_conscriptAccessNumber != value)
                    _conscriptAccessNumber = value;
            }
        }

        private string _conscriptAccessDate;

        public string ConscriptAccessDate
        {
            get
            {
                return Conscript.AccessFormDate;
            }

            set
            {
                if (_conscriptAccessDate != value)
                    _conscriptAccessDate = value;
            }
        }

        private string _conscriptStat;

        public string ConscriptStat
        {
            get
            {
                return Conscript.Stat;
            }

            set
            {
                if (_conscriptStat != value)
                    _conscriptStat = value;
            }
        }

        private string _conscriptOPS;

        public string ConscriptOPS
        {
            get
            {
                return Conscript.OPS;
            }

            set
            {
                if (_conscriptOPS != value)
                    _conscriptOPS = value;
            }
        }

        private string _conscriptCommandNumber;

        public string ConscriptCommandNumber
        {
            get
            {
                return Conscript.OSPNumber;
            }

            set
            {
                if (_conscriptCommandNumber != value)
                    _conscriptCommandNumber = value;
            }
        }

        private string _conscriptHasChild;

        public string ConscriptHasChild
        {
            set
            {
                if (_conscriptHasChild != value)
                    _conscriptHasChild = value;
            }

            get
            {
                return Conscript.HasChild == 1 ? "Да" : "Нет";
            }
        }

        private string _conscriptCommandRyad;

        public string ConscriptCommandRyad
        {
            get
            {
                return $"№ Приказа {Conscript.NPr} от {Conscript.DPr}";
            }

            set
            {
                if (_conscriptCommandRyad != value)
                    _conscriptCommandRyad = value;
            }
        }

        private string _сonscriptCommandVesh;

        public string ConscriptCommandVesh
        {
            get
            {
                return $"№ Аттестата {Conscript.Nvesh} от {Conscript.Dvesh}";
            }

            set
            {
                if (_сonscriptCommandVesh != value)
                    _сonscriptCommandVesh = value;
            }
        }

        private string _conscriptArrivalDate;

        public string ConscriptArrivalDate
        {
            get
            {
                return Conscript.ArrivalDate;
            }

            set
            {
                if (_conscriptArrivalDate != value)
                    _conscriptArrivalDate = value;
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
                if (_progressBarLabelVisibility != value)
                    _progressBarLabelVisibility = value;
            }
        }

        private RelayCommand _closeViewCommand;

        public RelayCommand CloseViewCommand
        {
            get
            {
                return _closeViewCommand ?? (_closeViewCommand = new RelayCommand(obj =>
                {
                    ConView.Close();
                }));
            }
        }

        private RelayCommand _showMoreDetailsAboutCommand;

        public RelayCommand ShowMoreDetailsAboutCommand
        {
            get
            {
                return _showMoreDetailsAboutCommand ?? (_showMoreDetailsAboutCommand = new RelayCommand(async obj =>
                {
                    DBWorker.Query = QueryHelper.ConscriptCommandAdditionQuery + $"*Что-то* = \'{Config.ConscriptList[Conscript.Conscription]}\' AND *Что-то* = \'{ConscriptCommandNumber}\'";

                    ProgressBarVisibility = "Visible";
                    OnPropertyChanged("ProgressBarVisibility");

                    await DBWorker.ExecuteQuery();

                    ProgressBarVisibility = "Hidden";
                    OnPropertyChanged("ProgressBarVisibility");

                    ConscriptCommand RecievedData = ((ConscriptCommand)DBWorker.RecievedData[0]);

                    ConscriptCommandViewModel ViewModel = new ConscriptCommandViewModel();
                    ConscriptCommandView View = new ConscriptCommandView(ViewModel, RecievedData);

                    View.Owner = ConView;
                    View.ShowDialog();
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
