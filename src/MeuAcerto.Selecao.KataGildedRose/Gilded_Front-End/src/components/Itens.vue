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
        <button v-on:click="AtualizarQualidade()" type="button" class="btn btn-primary">Atualizar Qualidade</button>
    </div>
</template>

<script>
import axios from 'axios';

export default {
  name: 'Itens',
  data: () => {
    return {
      itens: [],
    }
  },
  methods: {
    listar: (scope) => {
      axios.get(`https://localhost:44336/api`).then((res)=> {
        console.log(res)
        scope.itens = res.data
      })
    },
    AtualizarQualidade: () => {
        alert('Finji q atualizei')
    }
  },
  created() {
    this.listar(this)
  }
}
</script>