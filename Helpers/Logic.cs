//using EASendMail;
using System;
using LavantellAPIS.Context;
using LavantellAPIS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using LavantellAPIS.Helpers;


namespace LavantellAPIS.Helpers
{
    public class Logic
    {
        //public void EnviarCorreo(string correoDestino, string asunto, string mensajeCorreo)
        //{
        //    string mensaje = "Error al enviar correo";


        //    try
        //    {
        //        SmtpMail objetoCorreo = new SmtpMail("TryIt");

        //        objetoCorreo.From = "anderhenao329@gmail.com";
        //        objetoCorreo.To = correoDestino;
        //        objetoCorreo.Subject = asunto;
        //        objetoCorreo.TextBody = mensajeCorreo;

        //        SmtpServer objetoServidor = new SmtpServer("smtp.gmail.com");
        //        objetoServidor.User = "anderhenao329@gmail.com";
        //        objetoServidor.Password = "blakenanayxdpruebas";
        //        objetoServidor.Port = 587;
        //        objetoServidor.ConnectType = SmtpConnectType.ConnectSSLAuto;

        //        SmtpClient objetoCliente = new SmtpClient();
        //        objetoCliente.SendMail(objetoServidor, objetoCorreo);
        //        mensaje = "Correo Enviado Correctamente.";
        //    }
        //    catch (Exception ex)
        //    {
        //        mensaje = "Error al enviar correo." + ex.Message;

        //    }
        //}


        //public string EnviarCorreo2(string correoDestino, string asunto, string mensajeCorreo)
        //{
        //    string mensaje = "Error al enviar correo";


        //    try
        //    {
        //        SmtpClient MyServer = new SmtpClient();
        //        MyServer.Host = "smtp.gmail.com";
        //        MyServer.Port = 587;

        //        NetworkCredential NC = new NetworkCredential();
        //        NC.UserName = "anderhenao329@gmail.com";
        //        NC.Password = "blakenanayxdpruebas";
        //        //assigned credetial details to server
        //        MyServer.Credentials = NC;

        //        //create sender address
        //        MailAddress from = new MailAddress("anderhenao329@gmail.com", "Hola man");

        //        //create receiver address
        //        MailAddress receiver = new MailAddress("andersonhenao329@gmail.com", "Name want to display");

        //        MailMessage Mymessage = new MailMessage(from, receiver);
        //        Mymessage.Subject = contactanos.Ciudad;
        //        Mymessage.Body = contactanos.Mensaje;

        //        MyServer.Send(Mymessage);
        //    }
        //    catch (Exception ex)
        //    {
        //        mensaje = "Error al enviar correo." + ex.Message;

        //    }
        //    return mensaje;
        //}



        //public void enviarcorreosa(string correoDestino, string asunto, string mensajeCorreo, string telefono, string Ciudad, string Direccion)
        //{
        //    //created object of SmtpClient details and provides server details
        //    SmtpClient MyServer = new SmtpClient();
        //    MyServer.Host = "smtp.gmail.com";
        //    MyServer.Port = 587;
        //    MyServer.EnableSsl = true;

        //    //Server Credentials
        //    NetworkCredential NC = new NetworkCredential();
        //    NC.UserName = "anderhenao329@gmail.com";
        //    NC.Password = "enovpubytxnnjfou";
        //    //assigned credetial details to server
        //    MyServer.Credentials = NC;

        //    //create sender address
        //    MailAddress from = new MailAddress("anderhenao329@gmail.com");

        //    //create receiver address
        //    MailAddress receiver = new MailAddress("anderhenao329@gmail.com");

        //    MailMessage Mymessage = new MailMessage(from, receiver);
        //    Mymessage.Subject = asunto;
        //    Mymessage.Body = " Datos: " + "\n\r" + " Mensaje " + mensajeCorreo + "\n\r" + " telefono " + telefono + "\n\r" + " Ciudad " + Ciudad + "\n\r" + " Direccion " + Direccion + "\n\r" + " Correo " + correoDestino;
        //    //sends the email
        //    MyServer.Send(Mymessage);
        //}
        public void enviarcorreosa(Contactanos contactanos)
        {
            //created object of SmtpClient details and provides server details
            SmtpClient MyServer = new SmtpClient();
            MyServer.Host = "smtp.gmail.com";
            MyServer.Port = 587;
            MyServer.EnableSsl = true;

            //Server Credentials
            NetworkCredential NC = new NetworkCredential();
            NC.UserName = "anderhenao329@gmail.com";
            NC.Password = "enovpubytxnnjfou";
            //assigned credetial details to server
            MyServer.Credentials = NC;

            //create sender address
            MailAddress from = new MailAddress("anderhenao329@gmail.com");

            //create receiver address
            MailAddress receiver = new MailAddress("anderhenao329@gmail.com");

            MailMessage Mymessage = new MailMessage(from, receiver);
            Mymessage.Subject = contactanos.Nombre;
            Mymessage.Body = "\n\r" + " Hola, mi nombre es: " + contactanos.Nombre + ", pueden contactarme a través de mi teléfono el cual es " + contactanos.Telefono + " o mi correo " + contactanos.Correo + ", me encuentro ubicado en la ciudad de " + contactanos.Ciudad + "\n\r" + " con dirección " + contactanos.Direccion + "\n\r" + " ¡IMPORTANTE! : " + contactanos.Mensaje;
            //sends the email
            MyServer.Send(Mymessage);
        }
    }
}
