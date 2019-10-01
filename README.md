# HotChocolate-GraphQL-sample
Learn solution for GraphQL, HotChocolate, BFF incl. Schema Stitching



https://hotchocolate.io/docs/example-other-code-first 

https://www.youtube.com/watch?v=Lr6qyoAT8k4 

https://swapi.co/

https://graphql.org/swapi-graphql/

https://countries.trevorblades.com/



https://dev.leanix.net/docs/graphql-api



https://github.com/APIs-guru/graphql-apis



[GitHub API]([https://www.graphqlhub.com/playground?query=query%20TestQuery(%24currentUserName%3A%20String!%2C%20%0A%20%20%24includeRepos%3A%20Boolean!)%20%7B%0A%20%20graphQLHub%0A%20%20github%20%7B%0A%20%20%20%20user(username%3A%20%24currentUserName)%20%7B%0A%20%20%20%20%20%20...UserInfo%0A%20%20%20%20%20%20avatar_url%0A%20%20%20%20%20%20repos%20%40include(if%3A%20%24includeRepos)%20%7B%0A%20%20%20%20%20%20%20%20name%0A%20%20%20%20%20%20%7D%0A%20%20%20%20%7D%0A%20%20%7D%0A%7D%0A%0Afragment%20UserInfo%20on%20GithubUser%20%7B%0A%20%20id%0A%20%20user_name%3A%20login%0A%20%20company_name%3A%20company%0A%7D&variables=%7B%0A%20%20%22currentUserName%22%3A%20%22ebicoglu%22%2C%0A%20%20%22includeRepos%22%3A%20true%0A%7D](https://www.graphqlhub.com/playground?query=query TestQuery(%24currentUserName%3A String!%2C 
%24includeRepos%3A Boolean!) {
graphQLHub
github {
user(username%3A %24currentUserName) {
...UserInfo
avatar_url
repos %40include(if%3A %24includeRepos) {
name
}
}
}
}
fragment UserInfo on GithubUser {
id
user_name%3A login
company_name%3A company
}&variables={
"currentUserName"%3A "ebicoglu"%2C
"includeRepos"%3A true
})

[TODO API]([https://todo-mongo-graphql-server.herokuapp.com/?query=query%7B%0A%20%20todos%7B%0A%20%20%20%20id%0A%20%20%20%20title%0A%20%20%20%20completed%0A%20%20%7D%0A%7D](https://todo-mongo-graphql-server.herokuapp.com/?query=query{
todos{
id
title
completed
}
}))

https://medium.com/volosoft/building-graphql-apis-with-asp-net-core-419b32a5305b





