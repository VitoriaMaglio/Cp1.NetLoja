# Projeto CP1.NETLOJA

## Integrantes do Grupo

- Mateus Granja dos Santos - RM: 564930
- Vitoria Valentina Maglio - RM: 563509
- Felipe Maglio Filho - RM: 563512

## Domínio do Projeto
O projeto CP1.NETLOJA tem como domínio uma Loja

## Entidades Modeladas

As entidades que compõem o modelo de dados do sistema são:

- Cliente – armazena as informações dos clientes cadastrados no sistema, como nome, CPF, e-mail, telefone e data de cadastro.

- Pedido – registra os pedidos realizados pelos clientes, contendo data, status e valor total.

- Item_Pedido – representa os itens que fazem parte de um pedido, armazenando a quantidade e o preço unitário de cada produto.

- Produto – contém os dados dos produtos disponíveis para venda, como nome, descrição, preço e quantidade em estoque.

- Categoria – organiza os produtos em categorias para facilitar sua classificação.

- Pagamento – registra as informações relacionadas ao pagamento de um pedido, incluindo tipo de pagamento, valor e data.

## Resumo dos relacionamentos 

O modelo mostra um sistema simples de vendas. Nele, os clientes são responsáveis por realizar os pedidos, então cada pedido está ligado a um único cliente, mas um cliente pode ter feito vários pedidos ao longo do tempo.

Dentro de cada pedido existem os itens do pedido, que representam os produtos comprados naquela compra. Um pedido pode ter vários itens, enquanto cada item pertence apenas a um pedido específico. Esses itens também estão ligados aos produtos, já que cada item representa um produto do catálogo. Por isso, um mesmo produto pode aparecer em vários pedidos diferentes.

Os produtos são organizados por categorias, o que ajuda a manter o catálogo estruturado. Assim, uma categoria pode ter vários produtos associados, enquanto cada produto pertence somente a uma categoria.

Além disso, cada pedido possui um pagamento registrado, onde ficam informações como tipo de pagamento, valor e data em que foi realizado. Dessa forma, o pagamento fica diretamente relacionado ao pedido correspondente.

