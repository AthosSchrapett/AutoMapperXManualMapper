# AutoMapperXManualMapper - Comparativo entre AutoMapper e Mapeamento Manual

Este projeto tem como objetivo demonstrar as diferenças entre o uso do **AutoMapper** e o mapeamento manual em aplicações **C#/.NET**. A comparação inclui cenários práticos de performance, legibilidade e manutenção do código.

---

## 🔎 Visão Geral

O **AutoMapperXManualMapper** apresenta exemplos comparativos:
- Uso do **AutoMapper** para automação de mapeamento de objetos.
- Implementação de mapeamento manual, destacando o controle direto sobre o código.
- Testes de desempenho e complexidade em cenários com dados simples e complexos.

---

## 💼 Tecnologias Utilizadas
- **C#**
- **.NET 9**
- **AutoMapper**
- **BenchmarkDotNet** (para medir performance)

---

## 🔧 Configuração do Projeto

### 1. **Clonando o Repositório**

```bash
git clone https://github.com/AthosSchrapett/AutoMapperXManualMapper.git
cd AutoMapperXManualMapper
```

### 2. **Instalação das Dependências**

Certifique-se de instalar os pacotes necessários:

```bash
dotnet add package AutoMapper
dotnet add package BenchmarkDotNet
```

---

## ✅ Como Executar

1. Execute o projeto utilizando o **.NET CLI**:
   ```bash
   dotnet run --configuration Release
   ```
2. Os resultados dos benchmarks serão exibidos no terminal.

---

## 📊 Estrutura do Projeto

```
AutoMapperXManualMapper/
|-- Models/               # Classes de modelo (ex.: Source, Destination)
|-- Mappers/              # Configuração do AutoMapper e Mapeamento Manual
|-- MappingBenchmark.cs   # Testes de performance usando BenchmarkDotNet
|-- Program.cs            # Ponto de entrada
|-- README.md             # Documentação
```

---

## 📈 Exemplos de Uso

### **1. Configuração do AutoMapper**
```csharp
MapperConfiguration config = new MapperConfiguration(cfg => cfg.AddProfile<AutoMapperProfile>());
_mapper = config.CreateMapper();

//utilização do AutoMapper para converter a entidade em DTO
var dtos = _mapper.Map<List<PessoaDTO>>(_pessoas);
```

### **2. Implementação Manual**
```csharp

//Método de extenção do mapeamento manual
using AutoMapperXManualMapper.Models;

namespace AutoMapperXManualMapper.Mappers;
public static class ManualMapper
{
    public static PessoaDTO MapearParaDTO(this Pessoa pessoa)
    {
        return new PessoaDTO
        (
            pessoa.Nome,
            pessoa.Sobrenome,
            pessoa.Profissao,
            pessoa.CreatedAt.ToString("dd/MM/yyyy")
        );
    }
}

//utilização do método para converter cada pessoa da lista no DTO.
var dtos = _pessoas.Select(pessoa => pessoa.MapearParaDTO()).ToList();

```

---

## 📊 Benchmark de Performance

Exemplo de uso com o **BenchmarkDotNet** para comparar as duas abordagens:

```csharp
[Benchmark]
public List<PessoaDTO> AutoMapperMapping()
{
    return _mapper.Map<List<PessoaDTO>>(_pessoas);
}

[Benchmark]
public List<PessoaDTO> ManualMapping()
{
    return _pessoas.Select(pessoa => pessoa.MapearParaDTO()).ToList();
}
```

Resultados são exibidos em **tempo de execução** e **memória utilizada**.

---

## 💡 Contribuições
Contribuições são bem-vindas! Sinta-se à vontade para abrir uma **issue** ou enviar um **pull request** com melhorias e correções.

1. **Fork** o repositório
2. Crie sua branch com a funcionalidade/correção: `git checkout -b minha-feature`
3. Commit suas alterações: `git commit -m "Minha nova feature"`
4. Push: `git push origin minha-feature`
5. Abra um **Pull Request**

---

## 📊 Licença
Este projeto está licenciado sob a **MIT License**. Consulte o arquivo [LICENSE](LICENSE) para mais informações.

---

## 🌐 Contato
Caso tenha dúvidas ou precise de ajuda:
- **Athos Schrapett**
- [LinkedIn](https://www.linkedin.com/in/athos-louzeiro-schrapett)
- [GitHub](https://github.com/AthosSchrapett)

---

Feito com ❤️ por [AthosSchrapett](https://github.com/AthosSchrapett)

