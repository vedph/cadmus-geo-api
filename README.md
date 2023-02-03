# Cadmus Geography API

This API is used to develop Cadmus geography components.

Quick Docker image build:

    docker build . -t vedph2020/cadmus-geo-api:1.0.0 -t vedph2020/cadmus-geo-api:latest

(replace with the current version).

## History

# 1.0.0

- 2023-02-02: migrated to new components factory. This is a breaking change for backend components, please see [this page](https://myrmex.github.io/overview/cadmus/dev/history/#2023-02-01---backend-infrastructure-upgrade). Anyway, in the end you just have to update your libraries and a single namespace reference. Benefits include:
  - more streamlined component instantiation.
  - more functionality in components factory, including DI.
  - dropped third party dependencies.
  - adopted standard MS technologies for DI.

- 2023-01-26: updated packages.

### 0.0.2

- 2023-01-12: updated packages.
