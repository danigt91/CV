define(['app'], function (app) {
    return function ($scope) {

        $scope.resources = {};

        $scope.mainGridOptions = {
            dataSource: {
                type: "odata",
                transport: {
                    read: {
                        url: "/odata/GridItemViewModels",
                        dataType: "json"
                    }
                },
                pageSize: 5,
                serverPaging: true,
                serverSorting: true,
                batch: false,
                schema: {
                    data: function (data) {
                        //console.log(data)
                        return data['value'];
                    },
                    total: function (data) {
                        return data['odata.count'];
                    }
                }
            },
            sortable: true,
            pageable: true,
            columns: [{
                field: "ID",
                title: "ID",
                width: "120px"
            }, {
                field: "Nombre",
                title: "Nombre",
                width: "120px"
            }, {
                field: "Valor",
                width: "120px"
            }, {
                field: "Fecha",
                width: "120px"
            }
            ]
        };

    };
});