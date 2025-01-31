﻿using BT_Selenium.Actions;
using BT_Selenium.Tools;
using BT_Selenium.UI;
using OpenQA.Selenium;
using System;

namespace BT_Selenium.Task
{
    //Pantalla Carga Avanzada
    public class CargaAvanzada
    {

        public static void BuscarWC(IWebDriver driver)
        {
            Click.On(driver, CargaAvanzadaUI.BTNOPBUSCARWC);

        }

        public static void OrigenFondos(IWebDriver driver)
        {
             if (WaitHandler.IsVisible(driver, CargaAvanzadaUI.inputOrigenFondos) 
                && Get.InputValue(driver, CargaAvanzadaUI.inputOrigenFondos) == "")

                {
                    Click.On(driver, CargaAvanzadaUI.inputOrigenFondos);
                    Enter.Text(driver, CargaAvanzadaUI.inputOrigenFondos, "haberes");
                }
            
        }

        public static void Aceptar(IWebDriver driver)
        {

            Click.On(driver, CargaAvanzadaUI.BTNOPACEPTAR);
            WaitHandler.Wait(3);
            Click.On(driver, CargaAvanzadaUI.BTN_SI);

        }

    }
}
