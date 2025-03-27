$(function () {

    $("#AuthorFilter :input").on('input', function () {
        dataTable.ajax.reload();
    });

    //After abp v7.2 use dynamicForm 'column-size' instead of the following settings
    //$('#AuthorCollapse div').addClass('col-sm-3').parent().addClass('row');

    var getFilter = function () {
        var input = {};
        $("#AuthorFilter")
            .serializeArray()
            .forEach(function (data) {
                if (data.value != '') {
                    input[abp.utils.toCamelCase(data.name.replace(/AuthorFilter./g, ''))] = data.value;
                }
            })
        return input;
    };

    var l = abp.localization.getResource('CoreMvc');

    var service = aeq.coreMvc.books.author;
    var createModal = new abp.ModalManager(abp.appPath + 'Books/Author/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Books/Author/EditModal');

    var dataTable = $('#AuthorTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,//disable default searchbox
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList,getFilter),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('CoreMvc.Author.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('CoreMvc.Author.Delete'),
                                confirmMessage: function (data) {
                                    return l('AuthorDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('AuthorName'),
                data: "name"
            },
            {
                title: l('AuthorPhoneNumber'),
                data: "phoneNumber"
            },
            {
                title: l('AuthorEmail'),
                data: "email"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewAuthorButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
