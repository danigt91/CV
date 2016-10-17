define(['app'], function (app) {
    return function ($scope) {

        $scope.resources = {};

        $scope.mainGridOptions = {
            dataSource: {
                type: "odata",
                transport: {
                    read: {
                        beforeSend: function (req) {
                            req.setRequestHeader('Accept', 'application/json;odata=verbose');
                        },
                        url: "/odata/GridItemViewModels",
                        dataType: "json"
                    }
                },
                pageSize: 5,
                serverPaging: true,
                serverFiltering: true,
                serverSorting: true,
                batch: false,
                schema: {
                    model: {
                        id: "ID",
                        fields: {
                            ID: { type: "string" },
                            UserName: { type: "string" }
                        }
                        /*fields: {
                            ID: { type: "number" },
                            Nombre: { type: "string" },
                            Valor: { type: "number" },
                            Fecha: { type: "date" }
                        }*/
                    }
                    /* // The way to go when no Accept odata request header
                    data: function (data) {
                        //console.log(data)
                        return data['value'];
                    },
                    total: function (data) {
                        return data['odata.count'];
                    }
                    */
                }
            },
            sortable: true,
            pageable: {
                enable: true,
                pageSizes: true
            },
            reorderable: true,
            resizable: true,
            filterable: true,
            selectable: true,
            
            /*columns: [{
                field: "ID",
                title: "ID"
            }, {
                field: "Nombre",
                title: "Nombre"
            }, {
                field: "Valor"
            }, {
                field: "Fecha",
                format: "{0:dd-MM-yyyy hh:mm:ss}"
            }
            ]*/

            columns: [{
                field: "ID",
                title: "ID"
            }, {
                field: "UserName",
                title: "Nombre"
            }
            ]
        };

    };
});