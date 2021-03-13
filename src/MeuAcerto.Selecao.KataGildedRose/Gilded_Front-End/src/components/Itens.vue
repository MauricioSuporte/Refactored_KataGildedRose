<template>
    <div>
        <table class="table table-bordered table-striped table-dark text-center">
            <thead>
                <tr>
                    <th>
                        Nome
                    </th>
                    <th>
                        Prazo Para Venda
                    </th>
                    <th>
                        Qualidade
                    </th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="item in itens" v-bind:key="item.nome" >
                    <td>
                        {{item.nome}}
                    </td>
                    <td>
                        {{item.prazoParaVenda}}
                    </td>
                    <td>
                        {{item.qualidade}}
                    </td>
                </tr>
            </tbody>
        </table>
        <hr>
        <div class="text-center">
            <button v-on:click="atualizarQualidade()" type="button" class="btn btn-primary">Atualizar Qualidade</button>
        </div>
    </div>
</template>

<script>
import axios from 'axios';
let scopoItens = null;
export default {
  name: 'Itens',
  data: () => {
    return {
      itens: [],
    }
  },
  methods: {
    listar: () => {
      axios.get(`https://localhost:44336/api`).then((res)=> {
        scopoItens.itens = res.data
      })
    },
    atualizarQualidade: () => {
        axios.post(`https://localhost:44336/api/att`, scopoItens.itens).then((res)=> {
            scopoItens.itens = res.data
        })
    }
  },
  created() {
    scopoItens = this;
    this.listar()
  }
}
</script>

<style scoped>
button {
  margin-bottom: 3%;
}
</style>