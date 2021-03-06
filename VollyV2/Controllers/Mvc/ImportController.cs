﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VollyV2.Services;

namespace VollyV2.Controllers.Mvc
{
    [Authorize(Roles = "Admin")]
    public class ImportController : Controller
    {
        private readonly IImageManager _imageManager;

        public ImportController(IImageManager imageManager)
        {
            _imageManager = imageManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormFile postedFile)
        {
            string result = _imageManager.UploadImageAsync(postedFile, postedFile.FileName).Result;
            ViewData["message"] = result;
            return View();
        }
    }
}