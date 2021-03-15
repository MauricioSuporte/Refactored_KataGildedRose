<template>
    <div>
        <h2>Dia {{dias}}</h2>
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
      dias: 1
    }
  },
  methods: {
    listar: () => {
      axios.get(`https://localhost:44362/api`).then((res)=> {
        scopoItens.itens = res.data
      })
    },
    atualizarQualidade: () => {
        scopoItens.adicionarDias()
        axios.post(`https://localhost:44362/api/att`, scopoItens.itens).then((res)=> {
            scopoItens.itens = res.data
        })
    },
    adicionarDias: () => {
        console.log(scopoItens.dias)
        return scopoItens.dias++;
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

h2 {
  color: #4beb7b;
  font-size: 35px;
  text-align: center;
  font-family: Brush Script MT;
}
</style>