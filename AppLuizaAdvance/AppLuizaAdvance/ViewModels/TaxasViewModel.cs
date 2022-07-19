using AppLuizaAdvance.Models;
using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppLuizaAdvance.ViewModels
{
    class TaxasViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        int idPromotora;
        string nomePromotora;
        decimal parcela01, parcela02, parcela03, parcela04, parcela05, parcela06, parcela07, parcela08, parcela09, parcela10, parcela11, parcela12;

        public int IdPromotora 
        { 
            get => idPromotora;
            set
            {
                idPromotora = value;
                PropertyChanged(this, new PropertyChangedEventArgs("IdPromotora"));
            }
        }

        public string NomePromotora
        {
            get => nomePromotora;
            set
            {
                nomePromotora = value;
                PropertyChanged(this, new PropertyChangedEventArgs("NomePromotora"));
            }
        }

        public decimal Parcela01
        {
            get => parcela01;
            set
            {
                parcela01 = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Parcela01"));
            }
        }

        public decimal Parcela02
        {
            get => parcela02;
            set
            {
                parcela02 = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Parcela02"));
            }
        }

        public decimal Parcela03
        {
            get => parcela03;
            set
            {
                parcela03 = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Parcela03"));
            }
        }

        public decimal Parcela04
        {
            get => parcela04;
            set
            {
                parcela04 = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Parcela04"));
            }
        }

        public decimal Parcela05
        {
            get => parcela05;
            set
            {
                parcela05 = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Parcela05"));
            }
        }

        public decimal Parcela06
        {
            get => parcela06;
            set
            {
                parcela06 = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Parcela06"));
            }
        }

        public decimal Parcela07
        {
            get => parcela07;
            set
            {
                parcela07 = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Parcela07"));
            }
        }

        public decimal Parcela08
        {
            get => parcela08;
            set
            {
                parcela08 = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Parcela08"));
            }
        }

        public decimal Parcela09
        {
            get => parcela09;
            set
            {
                parcela09 = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Parcela09"));
            }
        }

        public decimal Parcela10
        {
            get => parcela10;
            set
            {
                parcela10 = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Parcela10"));
            }
        }

        public decimal Parcela11
        {
            get => parcela11;
            set
            {
                parcela11 = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Parcela11"));
            }
        }

        public decimal Parcela12
        {
            get => parcela12;
            set
            {
                parcela12 = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Parcela12"));
            }
        }

        public ICommand SalvarTaxas
        {
            get => new Command( async() =>
            {
                try
                {
                    TaxasModel model = new TaxasModel()
                    {
                        NomePromotora = this.NomePromotora,
                        Parcela01 = this.Parcela01,
                        Parcela02 = this.Parcela02,
                        Parcela03 = this.Parcela03,
                        Parcela04 = this.Parcela04,
                        Parcela05 = this.Parcela05,
                        Parcela06 = this.Parcela06,
                        Parcela07 = this.Parcela07,
                        Parcela08 = this.Parcela08,
                        Parcela09 = this.Parcela09,
                        Parcela10 = this.Parcela10,
                        Parcela11 = this.Parcela11,
                        Parcela12 = this.Parcela12
                    };

                    if(this.IdPromotora == 0)
                    {
                        await App.Database.Insert(model);
                    }
                } catch(Exception ex)
                {
                    await Application.Current.MainPage.DisplayAlert("Ops!!", ex.Message, "OK");
                }
            });
        }
    }
}
