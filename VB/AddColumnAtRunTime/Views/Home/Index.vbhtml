@Code
    ViewBag.Title = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

@Html.Partial("GridPartial", DisplayDetailInPopupWindow.Models.CustomerRepository.GetCustomers())

