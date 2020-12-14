import Vue from "vue";
import TableComponent from "./components/Table.vue";
import HelloComponent from "./Components/AppHello.vue";
var v = new Vue({
    el: "#app-table",
    template: '<TableComponent />',
    components: {
        TableComponent: TableComponent
    }
});
var v1 = new Vue({
    el: "#app-hello",
    template: '<HelloComponent />',
    components: {
        HelloComponent: HelloComponent
    }
});
//# sourceMappingURL=index.js.map