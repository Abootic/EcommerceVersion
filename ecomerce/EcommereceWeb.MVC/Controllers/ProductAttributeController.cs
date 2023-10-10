using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Domain.Entity;
using EcommereceWeb.Infrastraction.Data;
using EcommereceWeb.MVC.Controllers.Base;
using EcommereceWeb.MVC.Services;
using EcommereceWeb.MVC.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class ProductAttributeController : BaseMVCController
    {
        private readonly ICustomConventer _customConventer;
        private readonly ApplicationDbContext _applicationDbContext;

        public ProductAttributeController(ICustomConventer customConventer, ApplicationDbContext applicationDbContext)
        {
            _customConventer = customConventer;
            _applicationDbContext = applicationDbContext;
        }


        // GET: ProductAttributeController
        public async Task<IActionResult> Index(int productId)
        {
            ProductAttributeVM vm = new ProductAttributeVM();
            vm.productVariationDto = new List<ProductVariationDto>();
            
            var res = ServiceManager.ProductAttributeService.GetListVaration(productId);
            if (res.Status.Succeeded)
            {
                TempData["suc"] = res.Status.message;
                vm.productVariationDto = res.Data;
                vm.productId = productId;
                return View(vm);

            }
            TempData["err"] = res.Status.message;
            return View(vm);


        }

        public async Task<IActionResult> getAttrItems(int id)
        {
            var res = await ServiceManager.AttributeItemService.Find(a => a.AttributeId == id);

            if (res.Status.Succeeded)
            {
                ProductAdditionalVM vm = new ProductAdditionalVM();
                vm.checkBoxListVms = new List<CheckBoxListVm>();
                foreach (var item in res.Data)
                {

                    vm.CheckBoxListVm = new CheckBoxListVm
                    {
                        id = item.Id,
                        name = item.ArName
                    };

                    vm.checkBoxListVms.Add(vm.CheckBoxListVm);
                }

                return PartialView("_checkBoxList", vm);
            }
            return BadRequest("noo data");

        }
        public ActionResult Details()
        {
            return View();
        }
        public async Task<ActionResult> IndexProductAttribute(int id)
        {

            if (id != 0)
            {
                Console.WriteLine($"ffffffffffff   {id}");
                TempData.SetTemp<int>("ProductId", id);
                TempData.SetTemp<int>("isIndex", 1);
                TempData["Id"] = id;
                var res = await ServiceManager.ProductAttributeService.Find(a => a.ProductId == id);
                var mainRes = await ServiceManager.ProductService.GetById(id);
                if (mainRes.Status.Succeeded)
                {
                    TempData.SetTemp<string>("name", mainRes.Data.ArName);
                    TempData["Id"] = id;
                    if (res.Status.Succeeded)
                    {

                        return View(res.Data);
                    }
                    TempData["msg"] = res.Status.message;
                    return View();
                }
                else
                {
                    TempData["msg"] = "لا يوجد منتج  بهذا الرقم";
                    return RedirectToAction("IndexProd", "Product");
                }

            }
            else
            {
                return RedirectToAction("IndexProd", "Product");
            }
        }
        // GET: ProductAttributeController/Details/5
        [HttpGet]
        public IActionResult CreateVariation(int id, string name)
        {
            var productvaiation = new ProductVariationDto
            {
                ProductId = id,
                AttItemId = id.ToString(),
                EnName = name,

            };
            return PartialView("_varationForm", productvaiation);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateVariation(ProductVariationDto productVariationDto)
        {
            Console.WriteLine($"0000000000000000000000   {productVariationDto.EnName}");
            Console.WriteLine($"111111111111111111111   {productVariationDto.AttItemId}");
            Console.WriteLine($"2222222222222222222222   {productVariationDto.ProductId}");

            var res = await ServiceManager.ProductVariationService.Add(productVariationDto);
            if (res.Status.Succeeded)
            {
                return Ok(res.Status.message);
            }
            return BadRequest(res.Status.message);

        }
        // GET: ProductAttributeController/Create
        public ActionResult Create(int productId)
        {
            ProductAdditionalVM vm = new ProductAdditionalVM();
            vm.checkBoxListVms = new List<CheckBoxListVm>();
            vm.CheckBoxListVm = new CheckBoxListVm();
            vm.ProductId = productId;

            return View(vm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ProductAdditionalVM entity)
        {
            if (entity.AttributeItemId != null)
            {
                var AttributeItemIdList = entity.AttributeItemId.Split(",");
                var nameattrList = entity.Name.Split(",");

                for (int i = 0, k = 0; i < nameattrList.Length && k < AttributeItemIdList.Length; i++, k++)
                {

                    var ob = new ProductAttributeDto
                    {
                        AttributeId = entity.AttributeId,
                        AttributeItemId = int.Parse(AttributeItemIdList[k]),
                        ProductId = entity.ProductId,
                        Name = nameattrList[i]

                    };
                    var res = await ServiceManager.ProductAttributeService.Add(ob);
                    if (res.Status.Succeeded)
                    {
                        TempData["suc"] = res.Status.message;

                        //  return View();
                    }
                    else
                    {
                        TempData["err"] = res.Status.message;
                    }
                }
            }

            return RedirectToAction("Create", new { productId = entity.ProductId });


            //  Console.WriteLine($"2222222222222222222222  {d.AttributeItemId}");

        }

        public async Task<ActionResult> GetAttribute()
        {
            var res = await ServiceManager.AttributeService.GetAll();
            //   var list
            if (res.Status.Succeeded)
            {

            }
            return View();
        }



        // GET: ProductAttributeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductAttributeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductAttributeController/Delete/5
        public async Task<ActionResult> Delete(int Id)
        {
            try
            {
                var res = await ServiceManager.ProductAttributeService.Remove(Id);
                if (res.Status.Succeeded)
                {
                    TempData["msg"] = res.Status.message;
                    TempData["suc"] = "تم الحذف بنجاح";
                    return RedirectToAction("IndexProductAttribute", new { id = TempData["Id"] });
                }
                else
                {


                    TempData["msg"] = res.Status.message;
                    TempData["didentDelete"] = "لا يمكن حذف العنصر لانه هناك بيانات في جداول  اخرى متعلقة في هذا العنصر .قم بحذف البيانات المتعلقة بعدين احذف العنصر";

                    return RedirectToAction("IndexProductAttribute", new { id = TempData["Id"] });
                }

            }


            catch (Exception ex)
            {

                TempData["msg"] = $"error {ex.Message}  ";
                return RedirectToAction("IndexProductAttribute", new { id = TempData["Id"] });
            }

        }
    }
}