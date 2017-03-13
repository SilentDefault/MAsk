function comentar(id) {
    document.getElementById('postStatus').innerText = document.getElementById('estado' + id).innerText;
    postID = id;
    $.ajax({
        type: "POST",
        url: 'zoe.asmx/Comments',
        data: "{ 'post':'" + id + "'}",
        content: "json",
        contentType: "application/json",
        error: function (xhr) {
            alert('Ocurrio un error');
        },
        beforeSend: function () {
            $('<table class="auto-style2" style="border-bottom: 1px solid #ccd6dd;" >' +
                '<tr><td colspan="2"><center>...Procesando...</center> </td></tr>' +
                '</table>').appendTo('#comments');
        },
        success: function (data) {
            data = data.d;
            $('#comments').empty();
            if (data.length > 0) {
                $.each(data, function (key, producto) {
                    var zxc = producto.Mask;
                    if (producto.User != '---') {
                        if (producto.Mask != 'Anónimo') {
                            zxc = '<a href="../@@' + producto.User + '">' + producto.User + '</a> [' + producto.Mask + ']';
                        } else {
                            zxc = '<a href="../@@' + producto.User + '">' + producto.User + '</a>';
                        }
                    }
                    if (data.length != (key + 1)) {
                        $('<table class="auto-style2" style="border-bottom: 1px solid #ccd6dd;" ><tr>' +
                            '<td class="auto-style3">' + zxc + '</td>' +
                            '<td class="auto-style3" style="text-align:right"><abbr title="' + moment(producto.Date).format('LLLL') + '">' + moment(producto.Date).fromNow() + '</abbr></td></tr><tr>' +
                            '<td class="hide"><img src="' + producto.urlMedia + '" alt="Alternate Text" />' +
                            '<video controls="controls"><source src="' + producto.urlMedia + '" type="video/mp4" />' +
                            '<source src="' + producto.urlMedia + '" type="video/webm" /></video></td></tr>' +
                            '<tr><td colspan="2">' + producto.Content + '</td></tr>' +
                            '</table>').appendTo('#comments');
                    } else {
                        $('<table class="auto-style2" ><tr>' +
                            '<td class="auto-style3">' + zxc + '</td>' +
                            '<td class="auto-style3" style="text-align:right"><abbr title="' + moment(producto.Date).format('LLLL') + '">' + moment(producto.Date).fromNow() + '</abbr></td></tr><tr>' +
                            '<td class="hide"><img src="' + producto.urlMedia + '" alt="Alternate Text" />' +
                            '<video controls="controls"><source src="' + producto.urlMedia + '" type="video/mp4" />' +
                            '<source src="' + producto.urlMedia + '" type="video/webm" /></video></td></tr>' +
                            '<tr><td colspan="2">' + producto.Content + '</td></tr>' +
                            '</table>').appendTo('#comments');
                    }
                });
            } else {
                $('<table class="auto-style2" id="ningunComentario">' +
                    '<tr><td><center>No existen comentarios, se el primero :)</center> </td></tr>' +
                    '</table>').appendTo('#comments');
            }
        }
    });
    $(".commentModal").modal();
}