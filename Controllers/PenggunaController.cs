using System;
using System.Collections.Generic;
using ASPCoreGroupB.DAL;
using ASPCoreGroupB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreGroupB.Controllers
{
    public class PenggunaController : Controller{
        private IPengguna _pengguna;
        public PenggunaController(IPengguna pengguna){
            _pengguna = pengguna;
        }

        public IActionResult Registrasi(){
            return View();
        }

        public IActionResult Login(){
            return View();

        }

        [HttpPost]
        
        public IActionResult Login(string username,string password){
            try{
                var pgn = _pengguna.CekLogin(username,password);
                HttpContext.Session.SetString("username",pgn.Username);
                HttpContext.Session.SetString("aturan",pgn.Aturan);
                ViewData["pesan"] = $"Selamat Datang {pgn.Username} anda berhasil login";
                return View("Views/Home/Index.cshtml");
            }catch(Exception ex){
                ViewData["pesan"] = $"<span class='alert alert-danger'>{ex.Message}</span>";
                return View();
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }
        [HttpPost]
        public IActionResult RegistrasiPost(Pengguna pengguna){
            try{
                _pengguna.Insert(pengguna);
                ViewData["pesan"]=
                    "<span class='alert alert-success'>Data Pengguna Berhasil Ditambah</span>";
                return View("Registrasi");
            }
            catch(Exception ex){
                ViewData["pesan"]=
                $"<span class='alert alert-danger'> Data Gagal Ditambah, {ex.Message}</span>";
                return View("Registrasi");
            }
        }
    }
}