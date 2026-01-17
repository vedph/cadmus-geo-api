# Cadmus Geography API

This API is used to develop Cadmus geography components.

🐋 Quick Docker image build (you need to have a `buildx` container):

```bash
docker buildx create --use

docker buildx build . --platform linux/amd64,linux/arm64,windows/amd64,windows/arm64 -t vedph2020/cadmus-geo-api:1.0.3 -t vedph2020/cadmus-geo-api:latest --push
```

(replace with the current version).

## History

- 2026-01-17: updated packages.
- 2025-11-23: ⚠️ upgraded to NET 10.
- 2025-09-15: updated packages.
- 2025-06-03: updated packages.
- 2025-01-28: updated packages.
- 2025-01-24: updated packages.
- 2024-12-23: updated packages.
- 2024-12-03: updated packages.
- 2024-11-30: updated packages.
- 2024-11-20: updated packages.

### 5.0.0

- 2024-11-18: ⚠️ upgraded to .NET 9.
- 2024-06-09: updated packages.
- 2024-05-24: updated packages.
- 2024-03-22: updated packages.
- 2023-11-21: updated packages.

### 4.0.0

- 2023-11-18: ⚠️ Upgraded to .NET 8.
- 2023-11-09: updated packages.
- 2023-11-07: updated packages.

### 3.0.0

- 2023-06-17: moved to PostgreSQL.
- 2023-06-02: updated packages.

### 2.0.0

- 2023-05-24: updated packages (breaking change in general parts introducing [AssertedCompositeId](https://github.com/vedph/cadmus-bricks-shell/blob/master/projects/myrmidon/cadmus-refs-asserted-ids/README.md#asserted-composite-id)).
- 2023-05-16: updated packages.
- 2023-02-11: updated packages (minor change in toponym model).

### 1.0.0

- 2023-02-02: migrated to new components factory. This is a breaking change for backend components, please see [this page](https://myrmex.github.io/overview/cadmus/dev/history/#2023-02-01---backend-infrastructure-upgrade). Anyway, in the end you just have to update your libraries and a single namespace reference. Benefits include:
  - more streamlined component instantiation.
  - more functionality in components factory, including DI.
  - dropped third party dependencies.
  - adopted standard MS technologies for DI.

- 2023-01-26: updated packages.

### 0.0.2

- 2023-01-12: updated packages.
