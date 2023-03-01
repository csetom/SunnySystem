import { createRouter, createWebHistory } from "vue-router";
import App from './App.vue'
import Login from './components/Login.vue'

import MyError from './MyError.vue'



const routes = [
  {
    path: "/login",
    name: "Login",
    component: Login,
    // children:[
    //   {
    //     path:"/home",
    //     name:"home",
    //     component: Home,
    //   }
    // ]
  },
  {
    path: "/myerror",
    name: "about",
    component: MyError,
  },
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

export default router;
