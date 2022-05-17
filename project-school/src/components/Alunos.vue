<template>
  <div>
    <h1>{{titulo}}</h1>
    <input type="text" placeholder="Nome do Aluno" v-model="nome">
    <table border="1px">
      <thead>
        <th>Mat.</th>
        <th>Nome</th>
        <th>Opções</th>
      </thead>
      <tbody>
        <tr>
          <td>1</td>
          <td>Paulo</td>
          <td>
            <button class="btn" @click="remover()">Remover</button>
          </td>
        </tr>
        <tr>
          <td>2</td>
          <td>Isadora</td>
          <td>
            <button class="btn" @click="remover()">Remover</button>
          </td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>
export default {
  data() {
    return {
      titulo: 'Aluno',
      nome: 'Alunos',
    }
  },
  props: {},
};
</script>

<style scoped>
</style>
