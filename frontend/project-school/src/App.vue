<template>
  <div id="app">
    <Nav></Nav>
    <div class="marginPrincipal">
      <router-view :key="$route.fullPath"></router-view>
    </div>
  </div>
</template>

<script>
import Sobre from "./components/Sobre/Sobre.vue";
import Alunos from "./components/Aluno/Alunos";
import Professor from "./components/Professor/Professor";
import Nav from "./components/_nav/Nav";

export default {
  name: "App",
  components: {
    // eslint-disable-next-line vue/no-unused-components
    Alunos,
    // eslint-disable-next-line vue/no-unused-components
    Professor,
    Nav,
    // eslint-disable-next-line vue/no-unused-components
    Sobre,
  },
};
</script>

<style>
@import url("https://fonts.googleapis.com/css?family=Montserrat:400,700");

body {
  background-color: #eee;
  font-family: "Montserrat", sans-serif;
  display: grid;
  justify-items: center;
}
body,
html {
  margin: 0;
  height: 100%;
}

#app {
  width: 100%;
}

.marginPrincipal {
  width: 50%;
  margin: auto;
}

.btn_Danger {
  font-size: 0.8em !important;
  background-color: #fa4430;
}

.btn {
  font-weight: bold;
  color: white;
  padding: 10px 20px;
  cursor: pointer;
  font-size: 1.2em;
  border: 1px solid #000;
  border-radius: 5px;
  border-bottom: 3px solid black;
}

.btn:hover {
  text-shadow: 1px 1px 1px black;
  margin-top: 3px;
  border-bottom: 1px solid black;
}

table {
  margin: 0px;
  padding: 0px;
  list-style-type: none;
  width: 100%;
}

table tr td {
  padding: 20px;
  font-size: 1.3em;
  background-color: #e0edf4;
  margin-bottom: 2px;
  color: #3e5252;
}

table thead th {
  background-color: rgb(184, 208, 216) !important;
  font-size: 1.2em;
  padding: 10px 0px;
  text-align: center !important;
}

.colPequeno {
  width: 5%;
  text-align: right;
  background-color: rgb(125, 217, 245);
  font-weight: bold;
}
</style>
