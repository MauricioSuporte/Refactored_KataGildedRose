<template>
    <div id="titulo">
        <h1>{{titulo}}</h1>
    </div>
</template>

<script>
export default {
  name: 'Titulo',
  props: {
      titulo: String
  }
}
</script>

<style scoped>
h1 {
  color: #F5EF10;
  font-size: 100px;
  text-align: center;
  font-family: Brush Script MT;
}
</style>