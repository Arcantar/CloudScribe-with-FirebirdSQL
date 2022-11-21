# CloudScribe-with-FirebirdSQL
[CloudScribe](https://github.com/cloudscribe/cloudscribe) modules to use [FirebirdSQL](https://github.com/FirebirdSQL/firebird) 3,4 &amp; 5 as a database.

This code is in production via [adhes](https://adhes.net) with good results on a Rocky 9 & FirebirdSQL 5. ( [speedtest](https://pagespeed.web.dev/report?url=https%3A%2F%2Fadhes.net%2Fjung-et-limage-archetypique-du-heros) )

The data structure is the one generated by the EF-MySql version and has to be completely revised.

A search module with [Lucen_UDR](https://github.com/IBSurgeon/lucene_udr) will be developed soon.

The example also shows how to override the BootStrap4 menu to be fully BootStrap 5 compatible