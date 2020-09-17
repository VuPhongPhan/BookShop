﻿var user = {
    init: function () {
        user.registerEvents();
    },
    registerEvents: function () {
        $('.btn-active').off('click').on('click', function (e)
        {
            e.preventDefault();
            var btn = $(this);
            var id = btn.data('id')
            $.ajax({
                url: "/Admin/User/ChangeStatus",
                data: { id: id },
                dataType: "JSON",
                data:"POST",
                success: function (response) {
                    Console.log(response);
                    if (response.status == true) {
                        btn.text('Kích hoạt');
                    }
                    else {
                       btn.text('Khóa')
                    }
                }

            })
        });
    }
}
user.init();