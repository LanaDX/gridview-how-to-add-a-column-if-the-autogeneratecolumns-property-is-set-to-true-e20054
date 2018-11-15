<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/AddColumnAtRunTime/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/AddColumnAtRunTime/Controllers/HomeController.vb))
* [Data.cs](./CS/AddColumnAtRunTime/Models/Data.cs) (VB: [Data.vb](./VB/AddColumnAtRunTime/Models/Data.vb))
* [Index.cshtml](./CS/AddColumnAtRunTime/Views/Home/Index.cshtml)
* [GridPartial.cshtml](./CS/AddColumnAtRunTime/Views/Shared/GridPartial.cshtml)
<!-- default file list end -->
# GridView - How to add a column if the AutoGenerateColumns property is set to true


<p>When the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridView_AutoGenerateColumnstopic"><u>AutoGenerateColumns</u></a> property is set to true the only way to add a column the GridView is to handle the GridViewSettings.DataBound event. To avoid creating duplicate columns, it is necessary to add a condition that will check whether a column already exists.</p><p><strong>See also:</strong><strong><br />
</strong><a href="https://www.devexpress.com/Support/Center/p/E3587">ASPxGridView - How to add a column if the AutoGenerateColumns property is set to true</a></p>

<br/>


