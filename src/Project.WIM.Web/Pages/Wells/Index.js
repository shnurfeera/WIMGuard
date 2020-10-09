$(function () {
    var l = abp.localization.getResource('WIM');
    var createModal = new abp.ModalManager(abp.appPath + 'Wells/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Wells/EditModal');

    var dataTable = $('#WellsTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(project.wIM.wells.well.getList),
            columnDefs: [
                //TenantId = 1,
                //Name = "J-A2",
                //Field = "Jerun",
                //Platform = "Jerun A",
                //Psc = "SK408",
                //Producer = WellType.Gas,
                //Category = WellCategory.Normal
                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record });
                                    }
                                },
                                {
                                    test: l('Delete'),
                                    confirmMessage: function (data) {
                                        return l(
                                            'WellDeletionConfirmationMessage',
                                            data.record.name
                                        );
                                    },
                                    action: function (data) {
                                        project.wIM.wells.well
                                            .delete(data.record.id)
                                            .then(function () {
                                                abp.notify.info(
                                                    l('SuccessfullyDeleted')
                                                );
                                                dataTable.ajax.reload();
                                            });
                                    }
                                }
                            ]
                    }
                },
                {
                    title: l('TenantId'),
                    data: "tenantId"
                },
                {
                    title: l('Name'),
                    data: "name"
                },
                {
                    title: l('Field'),
                    data: "field"                
                },
                {
                    title: l('Platform'),
                    data: "platform"
                },
                {
                    title: l('PSC'),
                    data: "psc"
                },
                {
                    title: l('Producer'),
                    data: "producer"
                    ,
                    render: function (data) {
                        return l('Enum:WellType:' + data);
                    }
                },
                {
                    title: l('Category'),
                    data: "category"
                    ,
                    render: function (data) {
                        return l('Enum:WellCategory:' + data);
                    }
                },
                {
                    title: l('CreationTime'), data: "creationTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString(luxon.DateTime.DATETIME_SHORT);
                    }
                }
            ]
        })
    );

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });


    $('#NewWellButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});