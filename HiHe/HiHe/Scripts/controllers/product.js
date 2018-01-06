var productController = {
    init: function () {
        
        productController.loadData();
        productController.registerEven();
    },
    registerEven: function () {
        $("#btnAdd").off('click').on('click', function () {
            $("#myModal").modal('show');
        });
    },
    loadData : function ()
    {
        //$.ajax(
        //    {
        //        url: 'Load',
        //        type: 'GET',
        //        dataType: 'json',
        //        success: function (reponse) {
        //            if (reponse.status)
        //            {
        //                var data = reponse.data;
        //                var html = '';
        //                var template = $("#template").html();
        //                $.each(data, function (i, item) {
        //                    html += Mustache.render(template, {
        //                        Name: item.Name,
        //                        Img: item.Image,
        //                        Price: item.Price,
        //                        CategoryId: item.CategoryID,
        //                        Status: item.Status == true ? "<span class=\"label label-success\">Active</span>" :"Locked"
        //                    });
        //                });
        //                $("#tblData").html(html);

        //            }
        //        }
        //    }
        //);
    }
}
productController.init();