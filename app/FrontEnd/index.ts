import Vue from "vue";
import TableComponent from "./components/Table.vue";
import HelloComponent from "./Components/AppHello.vue";

let v = new Vue({
    el: "#app-table",
    template: '<TableComponent />',
    components: {
        TableComponent
    }
});
let v1 = new Vue({
    el: "#app-hello",
    template: '<HelloComponent />',
    components: {
        HelloComponent
    }
});