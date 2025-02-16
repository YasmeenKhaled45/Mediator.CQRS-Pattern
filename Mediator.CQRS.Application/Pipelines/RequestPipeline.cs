using FluentValidation;
using MediatR;

namespace Mediator.CQRS.Pipelines
{
    public class RequestPipeline<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> validators;
        public RequestPipeline(IEnumerable<IValidator<TRequest>> validators)
        {
            this.validators = validators;
        }

        public Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var context = new ValidationContext<TRequest>(request);
            var failures = validators.Select(o=>o.Validate(context))
                .SelectMany(om=>om.Errors).Where(oc=>oc != null).ToList();
            if (failures.Any())
                throw new ValidationException(failures);
            return next();
        }
    }
}
