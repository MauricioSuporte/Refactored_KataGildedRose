<template>
  <div id="app">
    <img alt="Gilded logo" src="./assets/logo.png">
    <Itens />
  </div>
</template>

<script>
import Itens from './components/Itens.vue'

export default {
  name: 'App',
  components: {
    Itens
  }
}
</script>