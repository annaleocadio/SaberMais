# Introdução

O avanço das tecnologias digitais transformou profundamente a forma como o conhecimento é produzido, distribuído e consumido. Nesse contexto, os cursos online se consolidaram como uma alternativa prática, acessível e democrática para o aprendizado contínuo, permitindo que milhões de pessoas possam estudar em diferentes lugares e horários. De acordo com pesquisas recentes, o mercado global de Educação a Distância (EAD) movimenta bilhões de dólares por ano e apresenta crescimento constante — estimativas apontam que o setor deve atingir valores entre US$ 248,84 bilhões em 2025 e US$ 419,31 bilhões em 2030, com crescimento médio anual de 11,01% (MORDOR INTELLIGENCE, 2024), podendo alcançar até US$ 279,30 bilhões em 2029 (STATISTA; ELEARNINGSTATS, 2025).

Apesar desses avanços, escolher um curso online adequado ainda representa um desafio. A imensa variedade de opções disponíveis em plataformas como Udemy, Coursera, Alura e similares pode confundir os estudantes, especialmente aqueles que estão iniciando sua jornada educacional ou buscam conteúdos muito específicos. Cada pessoa possui um estilo de aprendizado próprio, objetivos distintos e diferentes níveis de conhecimento prévio. Nesse cenário, surgem desafios típicos dos sistemas de recomendação, como o problema do cold start (dificuldade em sugerir opções para usuários ou cursos novos sem histórico de dados), além da necessidade de lidar com esparsidade, escalabilidade e excesso de popularidade em algumas recomendações (RECOMMENDER SYSTEMS, 2024). Assim, sem uma ferramenta de orientação eficaz, a tomada de decisão pode se tornar cansativa e pouco assertiva.

Com base nisso, este projeto propõe o desenvolvimento de uma aplicação interativa de recomendação de cursos online, baseada em perfis de usuários e no compartilhamento colaborativo de experiências. A proposta busca oferecer uma experiência personalizada, confiável e simplificada, ajudando os usuários a encontrar cursos que estejam alinhados às suas necessidades e preferências individuais. Modelos semelhantes já vêm sendo explorados em pesquisas: sistemas híbridos que combinam filtragem colaborativa e análise de conteúdo com algoritmos genéticos demonstraram ganhos de confiabilidade nas recomendações (ESTEBAN et al., 2024); plataformas adaptativas como o RiPPLE mostraram resultados positivos em termos de engajamento e aprendizagem (KHOSRAVI et al., 2019); e abordagens context-aware (sensíveis ao contexto) têm se mostrado eficazes na recomendação de cursos em MOOCs de larga escala (HOU et al., 2016).

## Problema

O crescimento acelerado das plataformas digitais ampliou a oferta de cursos online nos mais variados temas e formatos. Essa expansão trouxe benefícios, como flexibilidade de horários, acessibilidade geográfica e custos reduzidos. No entanto, também gerou um problema: a dificuldade de selecionar cursos de qualidade e adequados ao perfil do estudante.

Dados do Censo EAD Brasil (ABED, 2023) apontam que uma parte significativa dos alunos abandona cursos online antes da conclusão, muitas vezes por insatisfação com a didática, falta de clareza nos objetivos ou inadequação do conteúdo ao seu nível de conhecimento. Além disso, plataformas atuais ainda apresentam limitações no processo de recomendação, privilegiando algoritmos baseados em popularidade ou marketing, sem considerar a diversidade de estilos de aprendizagem e contextos individuais.

A ausência de um sistema de recomendação mais personalizado pode gerar frustração, desperdício de tempo e recursos, além de desmotivar os estudantes a continuar investindo em sua formação. Surge, portanto, a necessidade de uma solução capaz de facilitar a escolha de cursos, oferecendo recomendações baseadas não apenas em algoritmos, mas também em experiências colaborativas e no perfil específico de cada usuário.

## Objetivos

O objetivo geral deste projeto é desenvolver uma aplicação interativa de recomendação de cursos online, capaz de considerar diferentes perfis de usuários e avaliações colaborativas, com o intuito de melhorar a experiência de escolha e aumentar a satisfação com os conteúdos consumidos.

Como objetivos específicos, destacam-se:

- Mapear os principais fatores que influenciam a escolha de cursos online, como estilo de ensino, formato de conteúdo, duração, linguagem e perfil do instrutor.

- Desenvolver um sistema de categorização de perfis de usuários, considerando aspectos como preferências de aprendizado, objetivos educacionais, nível de conhecimento prévio e disponibilidade de tempo.

- Implementar um mecanismo de recomendação baseado em dados colaborativos, utilizando avaliações e feedbacks de usuários para sugerir cursos mais alinhados aos interesses individuais.

- Criar uma interface interativa e intuitiva, que permita ao usuário explorar recomendações, filtrar opções e visualizar detalhes relevantes dos cursos sugeridos.

- Testar e validar a eficácia da aplicação, por meio de estudos com usuários reais, medindo indicadores como satisfação, facilidade de uso e adequação das recomendações.

## Justificativa

A educação online desempenha papel cada vez mais relevante na formação de profissionais e estudantes, mas a abundância de opções pode tornar a escolha de cursos uma tarefa complexa e, muitas vezes, frustrante. Plataformas atuais oferecem mecanismos de busca e categorização, porém raramente consideram as características individuais do aprendiz ou integram experiências colaborativas de forma significativa.

Este projeto justifica-se pela necessidade de oferecer uma solução que vá além da simples busca por popularidade, proporcionando personalização, orientação e confiabilidade no processo de decisão. A aplicação proposta poderá contribuir tanto para usuários individuais — ao otimizar tempo e recursos investidos — quanto para instituições educacionais, que terão uma ferramenta adicional para divulgar cursos de forma mais direcionada.

Do ponto de vista acadêmico, a proposta contribui para pesquisas em sistemas de recomendação, usabilidade e interação humano-computador (IHC), além de dialogar com tendências de aprendizagem personalizada e colaborativa. Do ponto de vista social, busca democratizar o acesso ao conhecimento de qualidade, tornando o aprendizado online mais significativo e prazeroso.

## Público-Alvo

O sistema é voltado para pessoas e instituições interessadas em recomendar, divulgar ou encontrar cursos de qualidade. O público-alvo inclui:

- Estudantes de ensino médio, técnico ou universitário que buscam capacitação extra. 

- Profissionais que desejam aprimorar suas habilidades ou realizar transição de carreira. 

- Professores e educadores que compartilham cursos e formações relevantes para seus alunos. 

- Instituições públicas e privadas (escolas, universidades, ONGs, empresas) que desejam divulgar seus próprios cursos. 

- Público em geral, formado por pessoas que desejam compartilhar recomendações espontâneas e acessar um espaço confiável de indicações. 

